using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace chibi.dialog
{
	public class Dialogue_box : chibi.Chibi_behaviour
	{
		public Dialogue dialogues;
		public float letters_by_second = 10;
		public int current_dialogue = 0;
		public bool put_texy = false;

		public float total_delta_time = 0f;

		public UnityEngine.UI.Text dialogue_box;

		public string current_text
		{
			get {
				return dialogues.texts[ current_dialogue ];
			}
		}

		public void start_dialogue()
		{
			put_texy = true;
			dialogue_box.text = "";
		}

		public void pull_all_text()
		{
			dialogue_box.text = current_text;
			put_texy = false;
		}

		public void next_dialog()
		{
			++current_dialogue;
			if ( current_dialogue >= dialogues.texts.Count )
				current_dialogue = dialogues.texts.Count - 1;
			else
			{
				total_delta_time = 0f;
				put_texy = true;
			}
		}

		public void previous_dialog()
		{
			--current_dialogue;
			if ( current_dialogue < 0 )
				current_dialogue = 0;
			else
			{
				total_delta_time = 0f;
				put_texy = true;
			}
		}

		protected override void _init_cache()
		{
			base._init_cache();
			if ( !dialogue_box )
				Debug.LogError(
					string.Format(
						"the dialog box {0} no have assigned the TextBox",
						helper.game_object.name.full( this ) ) );
			if ( !dialogues )
				Debug.LogError(
					string.Format(
						"the dialog box {0} no have dialogues",
						helper.game_object.name.full( this ) ) );
		}
	}
}
