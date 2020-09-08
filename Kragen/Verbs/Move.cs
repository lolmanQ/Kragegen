using System;
using System.Collections.Generic;
using System.Text;
using Kragen.Engine;
using Kragen.Utilitys;

namespace Kragen.Verbs
{
	class Move : Verb
	{
		Pos2D newPos;
		Pos2D oldPos;

		bool moveObstruckted;
		public Move()
		{
			name = "Move";
			isTextBased = false;
			hasMods = true;
			allowedMods = new List<string>(){
				"up", "down", "left", "right",
				"u", "d", "l", "r"
			};
		}

		public override void Use()
		{
			base.Use();
			MakeMove();
			MakeOutText();
		}

		void MakeMove()
		{
			oldPos = new Pos2D();
			newPos = new Pos2D();
			oldPos = Game.Player.position;
			switch (InputHandler.mods[0])
			{
				case "u":
				case "up":
					newPos = new Pos2D(oldPos.x, oldPos.y - 1);
					break;
				case "d":
				case "down":
					newPos = new Pos2D(oldPos.x, oldPos.y + 1);
					break;
				case "l":
				case "left":
					newPos = new Pos2D(oldPos.x - 1, oldPos.y);
					break;
				case "r":
				case "right":
					newPos = new Pos2D(oldPos.x + 1, oldPos.y);
					break;
				default:
					newPos = oldPos;
					break;
			}
			if(CollisionHandler.CheckForObjInWorld(newPos, out Gameobjekt gameobjektHit))
			{
				if(gameobjektHit.hasCollision)
				{
					moveObstruckted = true;
				}
				else
				{
					moveObstruckted = false;
					Game.Player.position = newPos;
				}
			}
			else
			{
				moveObstruckted = false;
				Game.Player.position = newPos;
			}
		}

		new void MakeOutText()
		{
			if(moveObstruckted)
			{
				verbText = "Something is in the way";
			}
			else
			{
				verbText = "You moved to: " + newPos.x + ", " + newPos.y;
			}
		}
	}
}
