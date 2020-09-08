using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kragen.Utilitys;

namespace Kragen.Engine
{
	public class CollisionHandler
	{
		public static bool CheckForObjInWorld(Pos2D position, out Gameobjekt gameobjekt)
		{
			if(GoThroughAllObj(Game.gameObjList, position, out gameobjekt))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private static bool GoThroughAllObj(List<Gameobjekt> gameobjekts, Pos2D position, out Gameobjekt gameobjektHit)
		{
			//gameobjektHit = new Gameobjekt();
			Dev.Dis(gameobjekts.Count());
			foreach (Gameobjekt item in gameobjekts)
			{
				if(item.position.Equals(position))
				{
					gameobjektHit = item;
					return true;
				}				
			}
			gameobjektHit = null;
			return false;
		}
	}
}
