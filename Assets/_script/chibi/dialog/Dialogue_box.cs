using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace chibi.dialog
{
	public class Dialogue_box : chibi.Chibi_behaviour
	{
		public List<Dialogue> dialogues;
		public float letters_by_second = 10;
		public int current_dialogue = 0;
		public bool put_texy = false;

		public UnityEngine.UI.Text dialogue_box;

		public void start_dialogue()
		{
			put_texy = true;
		}

		public void pull_all_text()
		{
			dialogue_box.text = dialogues[ current_dialogue ].text;
		}

		public void next_dialog()
		{
			++current_dialogue;
			if ( current_dialogue >= dialogues.Count )
				current_dialogue = dialogues.Count - 1;
		}

		public void previous_dialog()
		{
			--current_dialogue;
			if ( current_dialogue < 0 )
				current_dialogue = 0;
		}

		protected override void _init_cache()
		{
			base._init_cache();
			if ( !dialogue_box )
				Debug.LogError(
					string.Format(
						"the dialog box {0} dont have assigned the TextBox",
						helper.game_object.name.full( this ) ) );
		}
	}
}
