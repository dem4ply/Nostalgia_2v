﻿using UnityEngine;


namespace chibi.inventory.item
{
	[ CreateAssetMenu( menuName="chibi/inventary/item/base" ) ]
	public class Item: chibi.Chibi_object
	{
		public Sprite image;
		public string description;
		public chibi.inventory.Item prefab;
		public int max_stack_amount;

		public virtual bool is_stackable
		{
			get {
				return max_stack_amount > 1;
			}
		}
	}
}
