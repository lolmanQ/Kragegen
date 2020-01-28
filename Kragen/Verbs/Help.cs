using System;
using System.Collections.Generic;
using System.Text;
using Kragen.Utilitys;
using Kragen.Engine;

namespace Kragen.Verbs
{
	class Help : Verb
	{
		public Help()
		{
			name = "Help";
			isTextBased = true;
			hasMods = true;
			skipUpdate = true;
			modsAllowedEmpty = true;
			allowedMods = new List<string>();
		}

		public override void Start()
		{
			foreach (Verb item in Game.verbs)
			{
				allowedMods.Add(item.name);
			}
		}

		public override void Use()
		{
			base.Use();
			MakeOutText();
		}

		new void MakeOutText()
		{
			verbText = "";
			if(InputHandler.mods.Count == 0)
			{
				verbText = "Comands: ";
				List<string> verbNameList = new List<string>();
				foreach (Verb item in Game.verbs)
				{
					verbNameList.Add(item.name);
				}
				verbText += verbNameList.ReturnAllString();
				return;
			}
		}
	}
}
