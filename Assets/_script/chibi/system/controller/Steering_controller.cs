using UnityEngine;
using Unity.Entities;

namespace chibi.systems.controller
{
	public class Steering_controller : ComponentSystem
	{
		struct group
		{
			public chibi.controller.steering.Steering sterring;
		}

		protected override void OnUpdate()
		{
			foreach ( var entity in GetEntities<group>() )
			{
				Vector3 desire_direction = Vector3.zero;
				float desire_speed = 1f;
				var controller = entity.sterring.controller;

				foreach ( var behavior in entity.sterring.behaviors )
				{
					var behavior_direction = behavior.desire_direction(
						entity.sterring.controller, entity.sterring.target );

					behavior_direction *= behavior.weight;
					desire_direction += behavior_direction;
				}

				controller.desire_direction = desire_direction;

				desire_speed = controller.motor.max_speed * desire_speed;
				controller.speed = desire_speed;
			}
		}
	}
}
