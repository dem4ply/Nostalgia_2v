using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using chibi.controller.avatar;

namespace chibi.dialog
{
	[System.Serializable]
	public class Actors
	{
		public List<Controller_avatar> actors;
	}

	[ CreateAssetMenu( menuName="dialogue/base" ) ]
	public class Dialogue : chibi.Chibi_object
	{
		[TextArea( 3, 10 )]
		public List<string> texts;
		public List< Actors > actors;

		public List<Controller_avatar> avatars;
	}
}
