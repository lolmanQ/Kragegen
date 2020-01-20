using System;
using System.Collections.Generic;
using System.Text;

namespace Kragen.InventorySystem.Armors
{
	class Helmet : Armor
	{
		public Helmet(int def, int lvl, string name)
		{
			this.lvl = lvl;
			this.name = name;
			this.def = def;
		}
	}
}
