using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kragen.Verbs;

namespace Kragen.Utilitys
{
	public static class MyExtentions
	{
		public static string ReturnAllString<T>(this List<T> list)
		{
			if(list.Count == 0)
			{
				return "";
			}

			string outString = "";
			for (int i = 0; i < list.Count; i++)
			{
				if(i == list.Count -1)
				{
					outString += list[i];
				}
				else
				{
					outString += list[i] + ", ";
				}
			}
			return outString;
		}

		public static string ReturnAllString<T>(this T[] array)
		{
			if (array.Length == 0)
			{
				return "";
			}

			string outString = "";
			for (int i = 0; i < array.Length; i++)
			{
				if (i == array.Length - 1)
				{
					outString += array[i];
				}
				else
				{
					outString += array[i] + ", ";
				}
			}
			return outString;
		}
	}
}
