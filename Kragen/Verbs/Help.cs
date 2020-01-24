using System;
using System.Collections.Generic;
using System.Text;
using Kragen.Utilitys;

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

		public override void Use()
		{
			base.Use();
			MakeOutText();
		}

		new void MakeOutText()
		{
			verbText = "Comands: ";
			List<string> verbNameList = new List<string>();
			foreach (Verb item in Game.verbs)
			{
				verbNameList.Add(item.name);
			}
			verbText += verbNameList.ReturnAllString();
		}
	}
}
