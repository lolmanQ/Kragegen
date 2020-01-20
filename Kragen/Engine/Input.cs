using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kragen.Verbs;

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
			string inputString = Console.ReadLine();
			inputString = inputString.ToLower();
			string[] inputAr = inputString.Split(' ');
			if (inputAr.Length != 0)
			{
				verb = inputAr[0];
				foreach (Verb item in Game.verbs)
				{
					if (verb == item.name.ToLower())
					{
						if (item.hasMods && inputAr.Length > 1)
						{
							foreach (string allowed in item.allowedMods)
							{
								if (allowed.ToLower() == inputAr[1])
								{
									mod = inputAr[1];
									return;
								}
							}
						}
						else if (!item.hasMods)
						{
							return;
						}
					}
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
