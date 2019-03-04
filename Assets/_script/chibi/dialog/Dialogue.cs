using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace chibi.dialog
{
	public class Dialogue : chibi.Chibi_object
	{
		[TextArea( 3, 10 )]
		public string text;
	}
}
