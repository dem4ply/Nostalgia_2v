using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using helper.test.assert;
using chibi.controller.ai;
using chibi.controller.npc;

namespace tests.dialog
{
	public class Dialogue_box : helper.tests.Scene_test
	{
		chibi.dialog.Dialogue_box dialogue_box;
		public override string scene_dir
		{
			get {
				return "tests/scene/chibi/dialog/dialog_manager";
			}
		}

		public override void Instanciate_scenary()
		{
			base.Instanciate_scenary();
			dialogue_box = helper.game_object.Find._<chibi.dialog.Dialogue_box>(
				scene, "dialogue_manager" );
		}

		[UnityTest]
		public IEnumerator when_the_dialog_start_should_show_the_text()
		{
			yield return new WaitForSeconds( 0.1f );
			Assert.Fail( "no implementada" );
		}

		[UnityTest]
		public IEnumerator if_start_is_no_executre_should_mantenint_the_text()
		{
			yield return new WaitForSeconds( 0.1f );
			Assert.Fail( "no implementada" );
		}

		[UnityTest]
		public IEnumerator when_execute_start_should_clean_the_text()
		{
			yield return new WaitForSeconds( 0.1f );
			Assert.Fail( "no implementada" );
		}

		[UnityTest]
		public IEnumerator pull_text_before_start_should_put_new_text()
		{
			yield return new WaitForSeconds( 0.1f );
			Assert.Fail( "no implementada" );
		}

		[UnityTest]
		public IEnumerator pull_text_after_start_no_add_more_dialog_of_nesesary()
		{
			yield return new WaitForSeconds( 0.1f );
			Assert.Fail( "no implementada" );
		}

		[UnityTest]
		public IEnumerator next_dialog_should_move_the_next_one()
		{
			yield return new WaitForSeconds( 0.1f );
			Assert.Fail( "no implementada" );
		}

		[UnityTest]
		public IEnumerator prev_dialog_should_move_the_next_one()
		{
			yield return new WaitForSeconds( 0.1f );
			Assert.Fail( "no implementada" );
		}
	}
}
