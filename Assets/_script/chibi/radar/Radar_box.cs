using UnityEngine;
using System.Collections.Generic;
using System;

namespace chibi.radar
{
	public class Radar_box : Radar
	{
		public Radar_box(
			Transform origin, Vector3 size, Vector3 direction, float distance,
			Quaternion rotation, List<LayerMask> masks )
			: base( origin, size, direction, distance, rotation, masks )
		{
		}

		public override void ping()
		{
			foreach ( LayerMask mask in masks )
			{
				RaycastHit[] current_hits = Physics.BoxCastAll(
					origin.position, size, direction, rotation, distance, mask.value );

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
							new Radar_hit( current_hits[i] );
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
