using System;
using System.Collections.Generic;
using System.Text;

namespace Kragen.Inventory
{
	class Item
	{
		protected int id;
		public int ID
		{
			get { return id; }
			protected set { id = value; }
		}
	}
}
