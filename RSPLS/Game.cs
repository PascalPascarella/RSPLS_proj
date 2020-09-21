using System;
using System.Collections.Generic;
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
			// User Selects How Many Players and Type
			// Game Start

			Console.WriteLine("Choose from the list below: ");
			gestures.ListsCondense();
			string playerGesture = Console.ReadLine();      // --> TODO: Find way to compare string/int values in Tuples
			gestures.PrintAttackList();
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
			// Type out if curious to see rules or what beats what
		}
	}
}
