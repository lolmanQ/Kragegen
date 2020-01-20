using System;
using System.Collections.Generic;
using System.Text;
using Kragen.Engine;
using Kragen.InventorySystem;

namespace Kragen
{
	class Player : Gameobjekt
	{
		private int health;
		public Inventory inventory = new Inventory();
		public int Health
		{
			get { return health; }
			private set { health = value; }
		}
		public Player()
		{
			inventory = new Inventory();
			symbole = "웃";
			isDrawn = true;
			health = 30;
			zIndex = 10;
		}

		public void TakeDamage(float amount, string type)
		{

		}
	}
}
