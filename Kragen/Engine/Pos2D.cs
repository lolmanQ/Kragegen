using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kragen.Engine
{
    public class Pos2D
    {
        public int x, y;

		public Pos2D(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public Pos2D()
		{
			x = 0;
			y = 0;
		}

		public static float Distens(Pos2D point1, Pos2D point2)
		{
			return MathF.Sqrt(MathF.Pow((point2.x - point1.x), 2)+MathF.Pow((point2.y - point1.x), 2));
		}
    }
}
