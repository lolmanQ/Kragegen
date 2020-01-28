using System;
using System.Collections.Generic;
using System.Text;
using Kragen.Engine;
using Kragen.InventorySystem;

namespace Kragen.Verbs
{
	class Inv : Verb
	{
		public Inv()
		{
			name = "Inv";
			isTextBased = true;
			hasMods = true;
			hasLineBreak = true;
			allowedMods = new List<string>(){
				"weapons", "w",
				"all", "a"
			};
		}

		public override void Use()
		{
			MakeOutText();
		}

		new public void MakeOutText()
		{
			verbText = "";
			switch (InputHandler.mods[0])
			{
				case "weapons":
				case "w":
					foreach (Item item in Game.Player.inventory.GetAllWeapons())
					{
						verbText += item.Name + ", Level: " + item.Level + "\n";
					}
					break;
				case "all":
				case "a":
					foreach (Item item in Game.Player.inventory.GetAllItems())
					{
						verbText += item.Name + "\n";
					}
					break;
			}

		}
	}
}
