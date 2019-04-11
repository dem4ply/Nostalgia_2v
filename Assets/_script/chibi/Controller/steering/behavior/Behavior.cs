using UnityEngine;
using System.Collections;
using controller;
using chibi.controller.actuator;
using Unity.Entities;
using System;

namespace chibi.controller.steering.behavior
{
	public abstract class Behavior : Chibi_object
	{
		public float weight = 1;
		public Color debug_color;
		public Color seek_color;

		public abstract Vector3 desire_direction(
			Controller controller, Transform target );

		public abstract float desire_speed(
			Controller controller, Transform target );

		public virtual void debug(
			Controller controller, Transform target )
		{
			Debug.Log( string.Format(
				"[sterring behavior] actuando en '{0}' hacia '{1}'",
				helper.game_object.name.full( controller ), target
			) );
		}

		public Vector3 seek( Controller controller, Vector3 target )
		{
			return target - controller.transform.position;
		}
	}

}
