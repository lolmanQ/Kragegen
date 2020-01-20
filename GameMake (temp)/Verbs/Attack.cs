using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
	public class Attack : Verb
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
