using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kragen.Engine
{
    public class Output
    {
		private static void SendOut(string outputString, bool needsLineBreak)
		{
			if (needsLineBreak)
			{
				Console.WriteLine(outputString);
			}
			else
			{
				Console.Write(outputString);
			}
		}

        public static void NormalText(string outputString, bool needsLineBreak)
		{
			Console.ResetColor();
			SendOut(outputString, needsLineBreak);
		}

		public static void ErrorText(string outputString, bool needsLineBreak)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			SendOut(outputString, needsLineBreak);
			Console.ResetColor();
		}

		public static void InputText(string outputString, bool needsLineBreak)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			SendOut(outputString, needsLineBreak);
			Console.ResetColor();
		}

		public static void SpaceLine(string outputString, bool needsLineBreak)
		{
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			SendOut(outputString, needsLineBreak);
			Console.ResetColor();
		}

		public static void VerbText(string outputString, bool needsLineBreak)
		{
			Console.ForegroundColor = ConsoleColor.Blue;
			SendOut(outputString, needsLineBreak);
			Console.ResetColor();
		}
    }
}
