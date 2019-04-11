using UnityEngine;
using System.Collections.Generic;
using controller;
using chibi.controller.actuator;
using Unity.Entities;
using System;
using System.Linq;

namespace chibi.controller.steering
{
	public class Steering : Chibi_behaviour
	{
		public Transform target;
		public Controller controller;
		public List<behavior.Behavior> behaviors;

		protected override void _init_cache()
		{
			base._init_cache();
			if ( !behaviors.Any() )
			{
				Debug.LogWarning( string.Format(
					"el steering controller de '{0}' no tiene behavior",
					helper.game_object.name.full( this )
				) );
			}
		}
	}
}
