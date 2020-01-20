using System;
using System.Collections.Generic;
using System.Text;

namespace Kragen.InventorySystem.Weapons
{
	class Sword : Weapon
	{
		
		public Sword(int dmg, int lvl, string name)
		{
			this.dmg = dmg;
			this.lvl = lvl;
			this.name = name;
		}
	}
}
