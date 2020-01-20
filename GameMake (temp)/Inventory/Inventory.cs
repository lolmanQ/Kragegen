using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ctest.Inventory;

namespace Default
{
    public class Inventory
    {
        public List<Item> storage = new List<Item>();
		
		public void AddItem(Item item)
		{
			storage.Add(item);
		}

		public void DestroyItem(Item item)
		{

		}
		
		public List<Item> GetAllWeapons()
		{
			List<Item> returnList = new List<Item>();
			foreach (var item in storage)
			{
				if(item.GetType().IsSubclassOf(typeof(Weapon)))
				{
					returnList.Add(item);
				}
			}
			return returnList;
		}

		public List<Item> GetAllArmor()
		{
			List<Item> returnList = new List<Item>();
			foreach (var item in storage)
			{
				if(item.GetType().IsSubclassOf(typeof(Armor)))
				{
					returnList.Add(item);
				}
			}
			return returnList;
		}

		public List<Item> GetAllItems()
		{
			return storage;
		}
    }
}
