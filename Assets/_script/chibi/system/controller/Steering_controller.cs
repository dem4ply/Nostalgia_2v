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
			float delta_time = Time.deltaTime;
			foreach ( var entity in GetEntities<group>() )
			{
				var behavior = entity.sterring.behavior;
				var desire_direction = behavior.desire_direction(
					entity.sterring.controller, entity.sterring.target );
				var desire_speed = behavior.desire_speed(
					entity.sterring.controller, entity.sterring.target );

				var controller = entity.sterring.controller;
				controller.desire_direction = desire_direction;

				desire_speed = controller.motor.max_speed * desire_speed;
				controller.speed = desire_speed;
			}
		}
	}
}
