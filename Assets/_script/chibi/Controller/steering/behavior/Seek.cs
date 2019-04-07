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
			return target.position - controller.transform.position;
		}

		public override float desire_speed(
			Controller controller, Transform target )
		{
			return 1f;
		}
	}
}
