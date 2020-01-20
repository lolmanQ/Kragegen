using System;
using System.Collections.Generic;
using System.Text;

namespace Kragen.Verbs
{
	class Info : Verb
	{
		public Info()
		{
			name = "Info";
			isTextBased = true;
			hasMods = true;
		}

		public override void Use()
		{
			base.Use();
			MakeOutText();
		}

		new void MakeOutText()
		{
			verbText = "Gives you info";
		}
	}
}
