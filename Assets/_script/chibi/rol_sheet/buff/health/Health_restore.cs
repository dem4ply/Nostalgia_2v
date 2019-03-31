using UnityEngine;


namespace chibi.rol_sheet.buff.health
{
	[ CreateAssetMenu( menuName="chibi/rol sheet/buff/health/restore" ) ]
	public class Health_restore : Buff
	{
		public float amount = 1f;

		public override void effect_in_rol_sheet( Rol_sheet rol_sheet )
		{
			float delta_amount = amount * delta;
			rol_sheet.hp += delta_amount;
			Debug.Log( string.Format(
				"curando '{0}' a {1}",
				delta_amount, helper.game_object.name.full( rol_sheet ) ),
				rol_sheet.gameObject );
		}
	}
}