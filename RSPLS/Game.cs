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
		public Player player1;
		public Player player2;
		public Gesture gestures;
		public int winningScore;
		public int userInputRules;
		public bool viewRules;
		public bool viewListAttacks;
		public string userGesture;


		// Constructor
		public Game()
		{

			player1 = new Human();
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
			GameTypeSelect();
			PrintScore();
			player1.GestureSelection();
			player2.GestureSelection();
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
					Console.WriteLine("ATTACK STRENGTHS: \n");
					gestures.PrintAttackList();
					var listAttackChoice = Console.ReadLine();
					viewRules = true;
				}
				else if (userChoice == "n" || userChoice == "N" || userChoice == "no" || userChoice == "No")
				{
					Console.WriteLine("Well alllllllrighty then, Mr. Smarty-Pants. Let us begin the game. \n");
					viewRules = true;
				}
				else
				{
					Console.WriteLine("Apologies, User. I do not speak gibberish. Please enter 'yes' or 'no': ");
					userChoice = Console.ReadLine();
				}
			}
		}
		// Gesture Comparison
		public void GestureCompare()
		{	// Look into switch cases instead of if-else
			if((player1.GestureSelection() == Convert.ToString(gestures.rock.ID)) &&
				(player2.GestureSelection() == Convert.ToString(gestures.lizard.ID) ||
				player2.GestureSelection() == Convert.ToString(gestures.wizard.ID) ||
				player2.GestureSelection() == Convert.ToString(gestures.scissors.ID) ||
				player2.GestureSelection() == Convert.ToString(gestures.spiderman.ID)))
			{
				if (player2.GestureSelection() == Convert.ToString(gestures.lizard.ID))
				{
					Console.WriteLine(gestures.rockAttack.attack1);
				}
				else if (player2.GestureSelection() == Convert.ToString(gestures.wizard.ID))
				{
					Console.WriteLine(gestures.rockAttack.attack2);
				}
				else if (player2.userGesture == Convert.ToString(gestures.scissors.ID))
				{
					Console.WriteLine(gestures.rockAttack.attack3);
				}
				else if (player2.userGesture == Convert.ToString(gestures.spiderman.ID))
				{
					Console.WriteLine(gestures.rockAttack.attack4);
				}
				player1.score++;
			}
		}

		// Display Score
		public void PrintScore()
		{
			Console.WriteLine("As it stands...\n" +
				$"Player 1's Score: {player1.score}\n" +
				$"Player 2's Score: {player2.score}");
		}
		// Game Type
		public void GameTypeSelect()
		{
			Console.WriteLine("Choose: \n1 for Human vs AI game\nor\n2 for Human vs Human game.");
			string userGT = Console.ReadLine();
			if (userGT == "1")
			{
				player2 = new Ai();       // Creates a Human vs AI game
				Console.WriteLine("An AI opponent approaches!");
			}
			else if (userGT == "2")
			{
				player2 = new Human();    // Creates a Human vs Human game
				Console.WriteLine("Another human approaches!");
			}
			else
			{
				GameTypeSelect();					// Recycles for user input validation
			}
		}
		//
	}
}
