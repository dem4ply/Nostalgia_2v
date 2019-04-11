using UnityEngine;
using System.Collections;
using controller;
using chibi.controller.actuator;
using Unity.Entities;

namespace chibi.controller.steering.behavior
{
	[CreateAssetMenu( menuName = "chibi/steering/behavior/wander" )]
	public class Wander : chibi.controller.steering.behavior.Behavior
	{
		public float circle_distance = 1f;
		public float circle_radius = 1f;

		public override Vector3 desire_direction(
			Controller controller, Transform target )
		{
			var circle_position = 
				controller.motor.velocity.normalized * circle_distance;
			circle_position += controller.transform.position;

			Quaternion rotation = helper.random.quaternion._();
			Vector3 direction = rotation * Vector3.one;
			Debug.Log( "sdfsadfasd" );
			var result = seek(
				controller, circle_position + ( direction * circle_radius ) );
			debug(
				controller, target, circle_position, direction, result );
			return result;
		}

		public override float desire_speed(
			Controller controller, Transform target )
		{
			return 1f;
		}

		public virtual void debug(
			Controller controller, Transform target, Vector3 circle_position,
			Vector3 direction, Vector3 seek_direction )
		{
			Debug.Log( controller.debug_mode );
			Debug.Log( controller, controller );
			controller.debug.draw.line( circle_position, debug_color );
			controller.debug.draw.sphere(
				circle_position, debug_color, circle_radius );
			controller.debug.draw.arrow(
				circle_position, direction, debug_color );

			controller.debug.draw.arrow( seek_direction, seek_color );

		}
	}
}
