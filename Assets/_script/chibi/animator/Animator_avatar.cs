using UnityEngine;
using System.Collections;
using chibi_base;

namespace chibi.animator.avatar
{
	public enum Emotions
	{
		normal, normal_close_eye, angry, hurt, surprised, happy,
	}

	public class Animator_avatar : Animator_base
	{
		public struct animator_vars
		{
			public const string EMOTION = "emotion";
		}

		[SerializeField]
		[HideInInspector]
		protected Emotions _emotion = Emotions.normal;

		#region Var public
		[SerializeField]
		public Emotions emotion
		{
			get {
				return _emotion;
				// return (Emotions)animator.GetInteger( animator_vars.EMOTION );
			}
			set {
				_emotion = value;
				animator.SetInteger( animator_vars.EMOTION, (int)value );
			}
		}
		#endregion

		#region funciones protegidas
		protected void OnEnable()
		{
			emotion = emotion;
		}
		#endregion
	}
}
