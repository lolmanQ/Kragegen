using System;
using System.Collections.Generic;
using System.Text;
using Kragen.Engine;

namespace Kragen.GameObj
{
	class Wall : Gameobjekt
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
