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
		public abstract Vector3 desire_direction(
			Controller controller, Transform target );

		public abstract float desire_speed(
			Controller controller, Transform target );
	}
}
