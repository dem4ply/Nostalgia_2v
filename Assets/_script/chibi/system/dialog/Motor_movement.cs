using UnityEngine;
using Unity.Entities;
using chibi.motor;

namespace chibi.systems.dialog
{
	public class Dialogue_box: ComponentSystem
	{
		struct group
		{
			public chibi.dialog.Dialogue_box dialogue_box;
		}

		protected override void OnUpdate()
		{
			float delta_time = Time.deltaTime;
			foreach ( var entity in GetEntities<group>() )
			{
				Debug.Log(
					string.Format( "processing dialogue box '{0}'",
					helper.game_object.name.full( entity.dialogue_box ) ) );
			}
		}
	}
}
