using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kragen.Engine
{
    public class Input
    {
        public static string verb;
		public static string mod;
		public static void NewCycle()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("make input");
			NewVerb();
		}

		public static void NewVerb()
		{
			Console.ForegroundColor = ConsoleColor.White;
			verb = Console.ReadLine();
			verb = verb.ToLower();
			foreach (Verb item in Game.verbs)
			{
				if(verb == item.name.ToLower())
				{
					return;
				}
			}
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("bad input");
			NewVerb();
		}

		public static void NewMod(List<string> listOfAllowed)
		{
			mod = Console.ReadLine();
			mod = mod.ToLower();
			foreach (string item in listOfAllowed)
			{
				if(mod == item.ToLower())
				{
					return;
				}
			}
			Console.WriteLine("input not alowed");
			NewMod(listOfAllowed);
		}
    }
}
