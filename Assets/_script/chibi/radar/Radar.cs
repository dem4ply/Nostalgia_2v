using UnityEngine;
using System;
using System.Collections.Generic;

namespace chibi.radar
{
	public class Radar
	{
		public Vector3 size;
		public Quaternion rotation;

		public List< LayerMask > masks;

		public Transform origin;

		public Dictionary< LayerMask, List< Radar_hit > > masks_hits;
		public List< Radar_hit > hits;

		public Radar(
			Transform origin, Vector3 size, Quaternion rotation,
			List<LayerMask> masks )
		{
			this.origin = origin;
			this.size = size;
			this.rotation = rotation;
			this.masks = masks;

			masks_hits = new Dictionary<LayerMask, List<Radar_hit>>();
			hits = new List< Radar_hit >();
		}

		public virtual void ping()
		{
			throw new NotImplementedException();
		}
	}
}
