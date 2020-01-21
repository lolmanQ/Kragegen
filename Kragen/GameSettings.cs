using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kragen
{
    public class GameSettings
    {
		private static bool isDevMode = true;
		public static bool IsDevMode { get => isDevMode;}
	}
}
