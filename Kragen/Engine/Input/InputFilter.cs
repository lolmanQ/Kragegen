using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kragen;
using Kragen.Utilitys;

namespace Kragen.Engine.Input
{
    public class InputFilter
    {
		static string outString;
		private static bool ReadLine()
		{
			string inputString = Console.ReadLine();
			string[] inputStringSplit = inputString.Split(".");
			if(GameSettings.IsDevMode)
			{
				if(inputStringSplit[0].ToLower() == "dev")
				{
					switch (inputStringSplit[1].ToLower())
					{
						case "quit":
							Dev.Dis("Exit via dev command");
							System.Environment.Exit(0);
							break;
						case "ping":
							Dev.Dis("This is a ping");
							break;
					}
					return false;
				}
				else
				{
					outString = inputString;
					return true;
				}
				
			}
			else
			{
				outString = inputString;
				return true;
			}
		}

		public static string ReadL()
		{
			while (true)
			{
				if(ReadLine())
				{
					return outString;
				}
			}
		}
        
    }
}
