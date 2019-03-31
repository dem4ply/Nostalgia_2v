using UnityEngine;
using System.Collections.Generic;
using chibi.rol_sheet.buff;


namespace chibi.rol_sheet
{
	public class Rol_sheet: chibi.Chibi_behaviour
	{
		public Sheet sheet;
		[ SerializeField ]
		public List<Buff_attacher> buffos;

		protected float _current_hp = -1f;
		protected float _raw_hp = 1f;
		protected float _const_added_hp = 0f;
		protected float _persentil_hp = 1f;

		public float max_hp
		{
			get {
				return _raw_hp;
			}
		}

		public float hp
		{
			get {
				return _current_hp;
			}
		}

		public void attach_buff( Buff buff )
		{
			Buff_attacher buff_attacher;
			buff_attacher = new Buff_attacher( buff, this );
			buffos.Add( buff_attacher );
		}

		protected override void _init_cache()
		{
			base._init_cache();
			buffos = new List<Buff_attacher>();
		}
	}
}