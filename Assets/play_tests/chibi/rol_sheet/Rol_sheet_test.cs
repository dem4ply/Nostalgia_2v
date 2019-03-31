using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using helper.test.assert;
using chibi.rol_sheet;
using chibi.rol_sheet.buff.health;

namespace tests.radar
{
	public class Rol_sheet_test : helper.tests.Scene_test
	{
		Rol_sheet rol_sheet;

		public override string scene_dir
		{
			get {
				return "tests/scene/chibi/rol_sheet/rol_sheet";
			}
		}

		public override void Instanciate_scenary()
		{
			base.Instanciate_scenary();
			rol_sheet = helper.game_object.Find._<Rol_sheet>( scene, "npc" );
			Assert.IsTrue( rol_sheet );
		}

		[UnityTest]
		public IEnumerator when_start_the_radar_should_be_empty()
		{
			yield return new WaitForSeconds( 0.1f );
			var buff = Health_restore.CreateInstance<Health_restore>();
			rol_sheet.attach_buff( buff );
			var attacher = rol_sheet.buffos.Find( x => x.buff == buff );
			Assert.IsNotNull( attacher );
			yield return new WaitForSeconds( 0.1f );
		}

		[UnityTest]
		public IEnumerator when_finish_is_period_should_be_remove()
		{
			yield return new WaitForSeconds( 0.1f );
			var buff = Health_restore.CreateInstance<Health_restore>();
			buff.duration = 1f;
			rol_sheet.attach_buff( buff );
			yield return new WaitForSeconds( 2f );
			var attacher = rol_sheet.buffos.Find( x => x.buff == buff );
			Assert.IsNull( attacher );
			yield return new WaitForSeconds( 0.1f );
		}

		[UnityTest]
		public IEnumerator if_no_have_limit_should_no_be_remove()
		{
			yield return new WaitForSeconds( 0.1f );
			var buff = Health_restore.CreateInstance<Health_restore>();
			buff.duration = 1f;
			buff.no_duration_limit = true;
			rol_sheet.attach_buff( buff );
			yield return new WaitForSeconds( 2f );
			var attacher = rol_sheet.buffos.Find( x => x.buff == buff );
			Assert.IsNull( attacher );
			yield return new WaitForSeconds( 0.1f );
		}
	}
}