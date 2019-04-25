using UnityEngine;
using System.Collections.Generic;
using System;

namespace chibi.radar
{
	[System.Serializable]
	public class Radar_box : Radar
	{

		public Radar_box( Radar_box radar ) : base( radar )
		{
		}
		public Radar_box(
			Transform origin, Vector3 size, Quaternion rotation, List<LayerMask> masks )
			: base( origin, size, rotation, masks )
		{
		}

		public override void ping()
		{
			var half_size = size * 0.5f;
			hits.Clear();
			foreach ( LayerMask mask in masks )
			{
				// helper.draw.cube.debug( origin.position, size, Color.yellow, 1f );
				var current_hits = Physics.OverlapBox(
					origin.position, half_size, rotation, mask.value );
				List<Radar_hit> results;
				if ( masks_hits.TryGetValue( mask, out results ) )
				{
					results.Clear();
					results.Capacity = current_hits.Length;
				}
				else
				{
					results = new List<Radar_hit>( current_hits.Length );
					masks_hits.Add( mask, results );
				}

				for ( int i = 0; i < current_hits.Length; ++i )
				{
					if ( current_hits[ i ].transform != origin )
					{
						Radar_hit current_radar_hit =
							new Radar_hit( current_hits[i], origin );
						results.Add( current_radar_hit );
						hits.Add( current_radar_hit );
					}
				}
				if ( results.Count == 0 )
					masks_hits.Remove( mask );
			}
		}
	}
}
