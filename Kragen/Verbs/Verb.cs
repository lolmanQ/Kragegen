using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kragen.Verbs
{
	public class Verb
	{
		public string name, verbText;
		public bool isTextBased, hasLineBreak = false, skipUpdate = false;
		public bool hasMods, modsAllowedEmpty;
		public List<string> allowedMods = new List<string>();

		public virtual void Start()
		{
			foreach (Verb item in Game.verbs)
			{
				allowedMods.Add(item.name);
			}
		}
		public virtual void Use()
		{
			
		}

		public virtual void MakeOutText()
		{

		}
	}
}
