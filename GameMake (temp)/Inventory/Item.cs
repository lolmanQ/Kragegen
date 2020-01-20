using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Default;

namespace ctest.Inventory
{
	public class Item
	{
		protected int id;
		public int ID{
			get{ return id; }
		}

		protected string name;
		public string Name{
			get{ return name; }
		}

		protected int lvl;
		public int Level{
			get{ return lvl; }
		}


	}
}
