using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace chibi.controller.actuator
{
	public class Actuador_controller : chibi.Chibi_behaviour
	{
		public chibi.controller.Controller controller;
		public chibi.actuator.Actuator current_actuator;

		public void action()
		{
			if ( current_actuator )
				current_actuator.action( controller );
			else
				Debug.LogError(
					string.Format( "no hay un actuador en {0}",
					helper.game_object.name.full( this ) ) );
		}
	}
}