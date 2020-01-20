using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ctest.Inventory
{
    public class Sword : Weapon
    {
		private int dmg;
		public int Dmg{
			get{ return dmg; }
			private set{ dmg = value; }
		}
        public Sword(int dmg, int lvl, string name)
		{
			this.dmg = dmg;
			this.lvl = lvl;
			this.name = name;
		}
    }
}
