using System;
using System.Collections.Generic;
using System.Text;

namespace Kragen.InventorySystem
{
	class Inventory
	{
		public List<Item> items = new List<Item>();

		public void AddItem(Item item)
		{
			items.Add(item);
		}

		public void DestroyItem(Item item)
		{

		}

		public List<Item> GetAllWeapons()
		{
			List<Item> returnList = new List<Item>();
			foreach (var item in items)
			{
				if (item.GetType().IsSubclassOf(typeof(Weapon)))
				{
					returnList.Add(item);
				}
			}
			return returnList;
		}

		public List<Item> GetAllArmor()
		{
			List<Item> returnList = new List<Item>();
			foreach (var item in items)
			{
				if (item.GetType().IsSubclassOf(typeof(Armor)))
				{
					returnList.Add(item);
				}
			}
			return returnList;
		}

		public List<Item> GetAllItems()
		{
			return items;
		}
	}
}
