using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
	public static class Dev
	{
		public static void Dis(int var)
		{
			Console.WriteLine("Debug: " + var);
		}
		public static void Dis(string var)
		{
			Console.WriteLine("Debug: " + var);
		}
		public static void Dis(float var)
		{
			Console.WriteLine("Debug: " + var);
		}
		public static void Dis(Pos2D var)
		{
			Console.WriteLine("Debug: x:" + var.x + " y:" + var.y);
		}

		public static void Dis(List<Pos2D> list)
		{
			Console.WriteLine("list:");
			foreach (var item in list)
			{
				Dis(item);
			}
		}
	}
}