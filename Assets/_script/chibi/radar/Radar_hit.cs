﻿using UnityEngine;
using System;
using System.Collections.Generic;

namespace chibi.radar
{
	public class Radar_hit
	{
		public Transform transform;
		public float distance;

		public Radar_hit( Transform obj, float distance )
		{
			this.transform = obj;
			this.distance = distance;
		}

		public Radar_hit( RaycastHit hit )
		{
			this.transform = hit.transform;
			this.distance = hit.distance;
		}

		public Radar_hit( Collider hit )
		{
			this.transform = hit.transform;
			this.distance = 0f;
		}
	}
}