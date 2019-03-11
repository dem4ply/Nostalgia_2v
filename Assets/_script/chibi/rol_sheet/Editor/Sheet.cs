using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using snippet.objects;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

namespace chibi.rol_sheet.editor
{
	[CustomEditor( typeof( Sheet ), true )]
	public class Sheet_inspector : Editor
	{
		SerializedProperty m_emotion;

		protected virtual void OnEnable()
		{
		}

		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();
		}
	}

}
