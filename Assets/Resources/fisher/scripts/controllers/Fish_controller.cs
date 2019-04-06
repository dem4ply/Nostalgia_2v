using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace fisher.controller
{
	public class Fish_controller : chibi.controller.Controller
	{
		public chibi.radar.Radar_box radar;
		public override void action( string name, string e )
		{
			base.action( name, e );
			switch ( name )
			{
				case chibi.joystick.actions.fire_1:
					switch ( e )
					{
						case chibi.joystick.events.down:
							eat();
							break;
					}
					break;
			}
		}

		public virtual void eat()
		{
			radar.ping();
			foreach ( var hit in radar.hits )
			{
				Debug.Log( hit.transform.name );
			}
		}

		private void OnDrawGizmos()
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawWireCube( radar.origin.position, radar.size );
		}

		protected override void _init_cache()
		{
			base._init_cache();
			radar = new chibi.radar.Radar_box( radar );
		}
	}
}