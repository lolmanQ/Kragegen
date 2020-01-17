using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    public static class LookUpTabels
    {
        public static List<string> ListOfVerbs = new List<string>(){
			"Quit", "Move", "Help"
		};
		public static List<int> ListOfVerbsIndex = new List<int>(){
			0, 0, 1
		};
    }
}
