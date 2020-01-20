using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Default;
using ctest.Inventory;

namespace ctest.Verbs
{
    public class Inv : Verb
    {
		public Inv()
		{
			name = "Inv";
			isTextBased = true;
			hasMods = true;
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
			switch (Input.mod)
			{
				case "weapons":
				case "w":
					foreach (Item item in Game.player.inventory.GetAllWeapons())
					{
						verbText += item.Name+", Level: "+item.Level+"\n";
					}
					break;
				case "all":
				case "a":
					foreach (Item item in Game.player.inventory.GetAllItems())
					{
						verbText += item.Name + "\n";
					}
					break;
			}
			
		}
    }
}
