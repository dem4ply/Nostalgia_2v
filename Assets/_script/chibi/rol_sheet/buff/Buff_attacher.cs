using UnityEngine;


namespace chibi.rol_sheet.buff
{
	[ SerializeField ]
	public class Buff_attacher
	{
		[ SerializeField ]
		public Buff buff;
		public float _total_duration = 0f;
		public float delta_sigma = 0f;

		public chibi.rol_sheet.Rol_sheet rol_sheet;

		public Buff_attacher( Buff buff, chibi.rol_sheet.Rol_sheet rol_sheet )
		{
			this.buff = buff;
			this.rol_sheet = rol_sheet;
			attach();
		}

		public float total_duration {
			get {
				return _total_duration;
			}

			set {
				_total_duration = value;
				delta_sigma = value;
				if ( buff.total_delta > delta_sigma )
				{
					effect_in_rol_sheet();
					delta_sigma -= buff.total_delta;
				}

				if ( total_duration > buff.duration )
					unattach();
			}
		}

		public void effect_in_rol_sheet()
		{
			buff.effect_in_rol_sheet( rol_sheet );
		}

		public void attach()
		{
			buff.attach( rol_sheet );
		}

		public void unattach()
		{
			buff.unattach( rol_sheet );
		}
	}
}
