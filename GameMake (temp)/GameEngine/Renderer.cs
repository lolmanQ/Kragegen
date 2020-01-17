using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    public class Renderer
    {
		public int gridWidth, gridHeight;
		Gameobjekt[,] displayAr;
		List<Pos2D> changedPoints;
		public Renderer(int width, int height)
		{
			gridWidth = width;
			gridHeight = height;
			displayAr = new Gameobjekt[width,height];
			changedPoints = new List<Pos2D>();
		}

		public void Start()
		{
			changedPoints.Clear();
			displayAr = new Gameobjekt[gridWidth,gridHeight];
		}

        public void AddObj(Gameobjekt gameobjekt)
		{
			//Dev.Dis(changedPoints);
			//Dev.Dis(changedPoints.Count);
			if(!gameobjekt.isDrawn){
				return;
			}
			if(!CheckIfInside(gameobjekt)){
				return;
			}
			if(changedPoints.Count == 0)
			{
				displayAr[gameobjekt.position.x, gameobjekt.position.y] = gameobjekt;
				changedPoints.Add(gameobjekt.position);
				//Dev.Dis(gameobjekt.position);
				return;
			}
			else
			{
				foreach (Pos2D item in changedPoints)
				{
					if(gameobjekt.position == item)
					{
						if(gameobjekt.zIndex > displayAr[item.x, item.y].zIndex)
						{
							displayAr[item.x, item.y] = gameobjekt;
							return;
						}
					}
				}
				displayAr[gameobjekt.position.x, gameobjekt.position.y] = gameobjekt;
				changedPoints.Add(gameobjekt.position);
				return;
			}
		}

		public void Draw()
		{
			string displayBuffer = "";
			for (int y = 0; y < gridHeight; y++)
			{
				displayBuffer = "";
				for (int x = 0; x < gridWidth; x++)
				{
					Gameobjekt current = displayAr[x,y];
					if(current == null)
					{
						current = new Gameobjekt();
					}
					if(current.isDrawn)
					{
						displayBuffer += current.symbole;
					}
					else
					{
						displayBuffer += "  ";
					}
				}
				Console.WriteLine(displayBuffer);
			}
		}

		bool CheckIfInside(Gameobjekt gameobjekt)
		{
			int x = gameobjekt.position.x;
			int y = gameobjekt.position.y;
			if(x >= 0 && x < gridWidth)
			{
				if(y >= 0 && y < gridHeight)
				{
					return true;
				}
				return false;
			}
			return false;
		}
    }
}
