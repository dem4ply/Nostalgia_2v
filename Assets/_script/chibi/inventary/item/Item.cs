using UnityEngine;


namespace chibi.inventary.item
{
	[ CreateAssetMenu( menuName="chibi/inventary/item/base" ) ]
	public class Item: chibi.Chibi_object
	{
		public Sprite image;
		public string description;
		public chibi.inventary.Item prefab;
		public int max_stack_amount;
	}
}
