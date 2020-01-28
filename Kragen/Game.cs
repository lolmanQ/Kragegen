using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kragen.Engine;
using Kragen.Verbs;
using Kragen.GameObj;
using Kragen.InventorySystem;
using Kragen.InventorySystem.Armors;
using Kragen.InventorySystem.Weapons;
using Kragen.Utilitys;

namespace Kragen
{
	public class Game
	{
		static bool gameRuning = true, inputRuning = true;
		public static List<Verb> verbs = new List<Verb>(){
			new Move(), new Help(), new Attack(), new Quit(), new Info(), new Inv()
		};
		public static Verb currentVerb;
		private static Player player;
		public static Renderer renderer;

		public static List<Gameobjekt> gameObjList;

		internal static Player Player { get => player; set => player = value; }

		public void Start()
		{
			foreach (Verb item in verbs)
			{
				item.Start();
			}

			Console.Clear();
			LoadContent();
			Loop();
		}

		void LoadContent()
		{
			renderer = new Renderer(5, 5);
			gameObjList = new List<Gameobjekt>();
			Player = new Player();
			Player.position = new Pos2D(2, 2);
			new Wall(new Pos2D(0, 0));
			new Wall(new Pos2D(0, 1));
			new Wall(new Pos2D(0, 2));
			new Wall(new Pos2D(0, 3));
			new Wall(new Pos2D(0, 4));

			Player.inventory.AddItem(new Sword(10, 4, "Start sword"));
			Player.inventory.AddItem(new Helmet(10, 3, "A hat"));
			Player.inventory.AddItem(new Sword(100, 1, "God sword"));
		}

		void Quiting()
		{

		}

		void Loop()
		{
			do
			{
				InputHandler.NewCycle();
				CheckInput();
				if (gameRuning)
				{
					Update();
					Render();
				}
			} while (inputRuning);
			Quiting();
		}

		void CheckInput()
		{
			if (InputHandler.verb.ToLower() == "quit") //Check if quit
			{
				gameRuning = false;
				inputRuning = false;
			}

			foreach (Verb item in verbs)
			{
				if (InputHandler.verb == item.name.ToLower())
				{
					currentVerb = item;
					break;
				}
			}
		}

		void Update()
		{
			currentVerb.Use();
			if(!currentVerb.skipUpdate)
			{
				foreach (Gameobjekt item in gameObjList)
				{
					item.Update();
				}
			}	
		}

		void Render()
		{
			renderer.Start();
			Console.Clear();
			Console.ResetColor();
			foreach (Gameobjekt item in gameObjList)
			{
				renderer.AddObj(item);
			}
			if (!currentVerb.isTextBased) // if not text based renders play field
			{

			}
			renderer.Draw();
			Output.VerbText(currentVerb.verbText, !currentVerb.hasLineBreak);
			Output.SpaceLine("-----------------------", true);
		}
	}
}
