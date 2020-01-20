using System;
using System.Collections.Generic;
using System.Text;

namespace Kragen.Verbs
{
	class Attack : Verb
	{
		public Attack()
		{
			name = "Attack";
			isTextBased = false;
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
