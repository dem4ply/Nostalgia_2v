using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace chibi.actuator
{
	public class Teleporter : Actuator
	{

		public override void action( controller.Controller controller )
		{
			Debug.Log(
				string.Format( "[Actuador] {0} teletransportando a {1}",
				helper.game_object.name.full( this ),
				helper.game_object.name.full( controller ) ) );
		}
	}
}