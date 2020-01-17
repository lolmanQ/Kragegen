using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    public class Move : Verb
    {
		Pos2D newPos;
		Pos2D oldPos;
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
			Input.NewMod(allowedMods);
			makeMove();
			MakeOutText();
		}

		void makeMove()
		{
			oldPos = new Pos2D();
			newPos = new Pos2D();
			oldPos = Game.player.position;
			switch (Input.mod)
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
			Game.player.position = newPos;
		}

		new void MakeOutText()
		{
			verbText = "You moved to: " + newPos.x + ", " + newPos.y; 
		}
    }
}
