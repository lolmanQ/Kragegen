using System;
using System.Collections.Generic;
using System.Text;
using Kragen.Engine;

namespace Kragen
{
	class Player : Gameobjekt
	{
		private int health;
		public int Health
		{
			get { return health; }
			private set { health = value; }
		}
		public Player()
		{
			symbole = "웃";
			isDrawn = true;
			health = 30;
			zIndex = 10;
		}
	}
}
