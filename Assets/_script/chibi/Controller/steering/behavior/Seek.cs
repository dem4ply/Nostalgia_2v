using UnityEngine;
using System.Collections;
using controller;
using chibi.controller.actuator;
using Unity.Entities;
using System;

namespace chibi.controller.steering.behavior
{
	[CreateAssetMenu( menuName = "chibi/steering/behavior/seek" )]
	public class Seek : chibi.controller.steering.behavior.Behavior
	{
		public override Vector3 desire_direction(
			Controller controller, Transform target )
		{
			var direction = seek( controller, target.position );
			direction.Normalize();
			debug( controller, target, direction );
			return direction.normalized;
		}

		public override float desire_speed(
			Controller controller, Transform target )
		{
			return 1f;
		}

		public virtual void debug(
			Controller controller, Transform target, Vector3 direction )
		{
			controller.debug.draw.arrow( direction, seek_color );
		}
	}
}
