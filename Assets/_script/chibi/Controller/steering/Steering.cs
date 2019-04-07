using UnityEngine;
using System.Collections;
using controller;
using chibi.controller.actuator;
using Unity.Entities;
using System;

namespace chibi.controller.steering
{
	public class Steering : Chibi_behaviour
	{
		public Transform target;
		public Controller controller;
		public behavior.Behavior behavior;

		protected override void _init_cache()
		{
			base._init_cache();
			if ( !behavior )
			{
				Debug.LogWarning( string.Format(
					"el steering controller de '{0}' no tiene behavior",
					helper.game_object.name.full( this )
				) );
			}
		}
	}
}
