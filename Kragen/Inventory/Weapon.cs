using System;
using System.Collections.Generic;
using System.Text;

namespace Kragen.InventorySystem
{
	class Weapon : Item
	{
		protected int dmg;
		public int Dmg
		{
			get { return dmg; }
			protected set { dmg = value; }
		}
		public virtual void Use()
		{

		}
	}
}
