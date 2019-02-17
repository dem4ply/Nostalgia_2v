﻿using UnityEngine;
using System.Collections;
using controller;
using chibi.controller.actuator;
using Unity.Entities;
using System;

namespace chibi.controller
{
	public class Controller : Chibi_behaviour
	{
		protected Vector3 _desire_direction;
		protected float _speed;

		public motor.Motor motor;
		public actuator.Actuador_controller actuator_controller;

		public virtual Vector3 desire_direction
		{
			get {
				return _desire_direction;
			}

			set {
				_desire_direction = value;
				motor.desire_direction = value;
				debug.draw.arrow( value, Color.black );
			}
		}

		public virtual float speed {
			get {
				return _speed;
			}

			set {
				_speed = value;
				motor.desire_speed = value;
			}
		}

		public virtual void activate()
		{
			if ( actuator_controller )
			{
				actuator_controller.action();
			}
			else
			{
				Debug.LogError(
					string.Format(
						"no esta asignado el actuator controller en '{0}'",
						helper.game_object.name.full( this ) ) );
			}
		}

		protected override void _init_cache()
		{
			base._init_cache();
			load_motors();
			load_actuator_controller();
		}

		protected virtual void load_motors()
		{
			motor = GetComponent<motor.Motor>();
			if ( !motor )
			{
				Debug.LogError(
					string.Format(
						"no se encontro un motor en el object {0}" +
						"se agrega un motor", name ) );
				motor = gameObject.AddComponent<motor.Motor>();
			}
		}

		protected virtual void load_actuator_controller()
		{
			// TODO: deberia de haber una mejor manera de hacer esto
			if ( !actuator_controller )
			{
				actuator_controller = GetComponent<Actuador_controller>();
				if ( !actuator_controller )
				{
					actuator_controller =
						GetComponentInChildren<Actuador_controller>();
					if ( !actuator_controller )
					{
						Debug.LogError(
							string.Format(
								"no se econtro un controller de actuadores en '{0}'",
								helper.game_object.name.full( this ) ) );
					}
				}
			}
			if ( actuator_controller )
				actuator_controller.controller = this;
			else
				Debug.LogError(
					string.Format(
						"no hay un actuador controller en '{0}'",
						helper.game_object.name.full( this ) ) );

		}
	}
}
