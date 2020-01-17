using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
	public class Gameobjekt
	{
		public Pos2D position;
		public string symbole;
		public bool isDrawn;
		public int zIndex;

		public Gameobjekt()
		{
			zIndex = 0;
			symbole = "  ";
			isDrawn = false;
		}

		public virtual void Update()
		{
			
		}
	}
}
