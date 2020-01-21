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
			hasCollision = true;
			Game.gameObjList.Add(this as Gameobjekt);
		}

		public Wall(Pos2D pos)
		{
			symbole = "#";
			isDrawn = true;
			hasCollision = true;
			position = pos;
			Game.gameObjList.Add(this as Gameobjekt);
		}
	}
}
