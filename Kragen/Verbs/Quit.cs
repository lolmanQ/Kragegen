using System;
using System.Collections.Generic;
using System.Text;

namespace Kragen.Verbs
{
	class Quit : Verb
	{
		public Quit()
		{
			name = "Quit";
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
			verbText = "You attackt!!";
		}
	}
}
