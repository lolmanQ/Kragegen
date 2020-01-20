using System;
using System.Collections.Generic;
using System.Text;

namespace Kragen.InventorySystem
{
	class Armor : Item
	{
		protected int def;
		public int Def
		{
			get { return def; }
			protected set { def = value; }
		}
	}
}
