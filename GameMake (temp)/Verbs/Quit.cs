using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    public class Quit : Verb
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
