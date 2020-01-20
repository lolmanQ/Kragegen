using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
	public class Wall : Gameobjekt
	{
		public Wall()
		{
			symbole = "#";
			isDrawn = true;
		}

		public Wall(Pos2D pos)
		{
			symbole = "#";
			isDrawn = true;
			position = pos;
		}
	}
}
