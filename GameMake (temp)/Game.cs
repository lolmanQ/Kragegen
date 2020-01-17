using System;
using System.Collections.Generic;

namespace Default
{
	public class Game
	{
		static bool gameRuning = true, inputRuning = true;
		public static List<Verb> verbs = new List<Verb>(){
			new Move(), new Help(), new Attack(), new Quit(), new Info()
		};
		public static Verb currentVerb;
		public static Gameobjekt player;
		public static Renderer renderer;

		public static List<Gameobjekt> gameObjList;

		public static void Start()
		{
			renderer = new Renderer(5,5);
			gameObjList = new List<Gameobjekt>();
			player = new Player();
			player.position = new Pos2D(2, 2);
			gameObjList.Add(player);
			gameObjList.Add(new Wall(new Pos2D(1,1)));
			
			Console.Clear();
			Loop();
		}

		static void Quiting()
		{
			
		}

		static void Loop()
		{
			do
			{
				Input.NewCycle();
				CheckInput();
				if(gameRuning){
					Update();
					Render();
				}
			} while(inputRuning);
			Quiting();
		}

		static void CheckInput()
		{
			if(Input.verb.ToLower() == "quit") //Check if quit
			{
				gameRuning = false;
				inputRuning = false;
			}
			
			foreach (Verb item in verbs)
			{
				if(Input.verb == item.name.ToLower())
				{
					currentVerb = item;
					break;
				}
			}
		}

		static void Update()
		{
			currentVerb.Use();
			foreach (Gameobjekt item in gameObjList)
			{
				item.Update();
			}
		}

		static void Render()
		{
			renderer.Start();
			Console.Clear();
			Console.ResetColor();
			renderer.AddObj(player);
			renderer.AddObj(gameObjList[1]);
			if(!currentVerb.isTextBased) // if not text based renders play field
			{
				
			}
			renderer.Draw();
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine(currentVerb.verbText);
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine("-----------------------");
		}
	}
}
