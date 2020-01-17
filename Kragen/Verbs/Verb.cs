using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kragen.Verbs
{
    public class Verb
    {
        public string name, verbText;
		public bool isTextBased, hasMods;
		public List<string> allowedMods;

		public virtual void Use()
		{

		}

		public virtual void MakeOutText()
		{

		}
    }
}
