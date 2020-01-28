using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kragen.Verbs;
using Kragen.Engine.Input;
using Kragen.Utilitys;

namespace Kragen.Engine
{
	public class InputHandler
	{
		public static string verb;
		public static List<string> mods = new List<string>();
		public static void NewCycle()
		{
			Output.InputText("Make input", true);
			NewVerb();
		}

		public static void NewVerb()
		{
			string inputString = InputFilter.ReadL();
			inputString = inputString.ToLower();
			string[] inputAr = inputString.Split(' ');
			if (inputAr.Length != 0)
			{
				verb = inputAr[0];
				foreach (Verb item in Game.verbs) // goes through all verbs that are in the list Game.verbs
				{
					if (verb == item.name.ToLower()) //if player first input is one of the verbs name
					{
						if (item.hasMods && inputAr.Length > 1)
						{
							foreach (string allowed in item.allowedMods)
							{
								if (allowed.ToLower() == inputAr[1])
								{
									mods.Add(inputAr[1]);
								}
							}
							if(mods.Count > 0)
							{
								return;
							}
						}
						else if (!item.hasMods || (item.hasMods && item.allowedMods.Count == 0))
						{
							return;
						}
						else if(item.modsAllowedEmpty && mods.Count == 0)
						{
							return;
						}
						if (item.hasMods)
						{
							Output.ErrorText("Allowed mods: " + item.allowedMods.ReturnAllString(), true);
						}
					}
				}
			}

			Output.ErrorText("Incorrect input", true);
			NewVerb();
		}

		/*
		public static void NewMod(List<string> listOfAllowed)
		{
			mod = InputFilter.ReadL();
			mod = mod.ToLower();
			foreach (string item in listOfAllowed)
			{
				if(mod == item.ToLower())
				{
					return;
				}
			}
			Output.ErrorText("input not alowed", true);
			NewMod(listOfAllowed);
		}
		*/
	}
}
