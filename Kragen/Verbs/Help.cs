using System;
using System.Collections.Generic;
using System.Text;

namespace Kragen.Verbs
{
	class Help : Verb
	{
		public Help()
		{
			name = "Help";
			isTextBased = true;
			hasMods = false;
		}

		public override void Use()
		{
			base.Use();
			MakeOutText();
		}

		new void MakeOutText()
		{
			verbText = "Comands: ";
			foreach (Verb item in Game.verbs)
			{
				verbText += item.name + ", ";
			}
		}
	}
}
