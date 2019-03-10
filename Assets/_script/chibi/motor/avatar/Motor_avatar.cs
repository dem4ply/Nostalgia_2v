using UnityEngine;
using System.Collections;
using controller;
using controller.animator;
using Unity.Entities;
using System;

namespace chibi.motor.avatar
{
	public enum Emotions
	{
		normal, normal_close_eye, angry, hurt, surprised, happy,
	}
	public class Motor_avatar : Motor
	{
		public Emotions emotion;
	}
}