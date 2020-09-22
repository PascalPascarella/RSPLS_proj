using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace RSPLS
{
	class Game
	{
		// Member Variables
		public Ai aiPlayer;
		public Human humanPlayer;
		public Gesture gestures;
		public int winningScore;
		public int userInputRules;
		public bool viewRules;
		public bool viewListAttacks;


		// Constructor
		public Game()
		{

			aiPlayer = new Ai();
			humanPlayer = new Human();
			gestures = new Gesture();
			winningScore = 3;

		}

		// Member Methods
		// Main
		public void GameRun()
		{
			// Player Greeting and Rules
			PlayerGreeting();
			gestures.PrintGestureList();
			Console.WriteLine("\n");
			ViewRules();

			// User Selects How Many Players and Type
			// Game Start
			// Declare Victor
			// Play Again?
			// Add Custom Gestures?


			//string playerGesture = Console.ReadLine();      // --> TODO: Find way to compare string/int values in Tuples

			//gestures.PrintAttackListRock();
			Console.ReadLine();
		}









		// Greeting
		public void PlayerGreeting()
		{
			Console.WriteLine("Welcome to...");
			Console.WriteLine();
		}
		// View Rules
		public void ViewRules()
		{
			// --> Type out if curious to see rules or what beats what
			Console.Write("Would you like to browse the entire list of attacks (Y/N)? ");
			string userChoice = Console.ReadLine();
			while (viewRules == false)
			{
				if (userChoice == "y" || userChoice == "Y" || userChoice == "yes" || userChoice == "Yes")
				{
					Console.WriteLine("Choose either the number or type in the attack from the list below: ");
					
					var listAttackChoice = Console.ReadLine();
					//while(viewListAttacks == false)
					//	if (viewListAttacks == valuesAndGestures)
					//	{

					//	}
					viewRules = true;
				}
				else if (userChoice == "n" || userChoice == "N" || userChoice == "no" || userChoice == "No")
				{
					Console.WriteLine("Well alllllllrighty then, Mr. Smarty-Pants. Let us begin the game.");
					viewRules = true;
				}
				else
				{
					Console.WriteLine("Apologies, User. I do not speak gibberish. Please enter 'yes' or 'no': ");
					userChoice = Console.ReadLine();
				}
			}
			//gestures.PrintAttackList();
		}
	}
}
