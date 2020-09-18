using System;
using System.Collections.Generic;
using System.Text;

namespace RSPLS
{
	class Game
	{
		// Member Variables
		public Gesture gestures;


		// Constructor
		public Game()
		{

			gestures = new Gesture();

		}

		// Member Methods
		// Main
		public void GameRun()
		{
			// Player Greeting and Rules
			PlayerGreeting();
			gestures.PrintGestureList();
		}

		// Greeting
		public void PlayerGreeting()
		{
			Console.WriteLine("Welcome to...");
			Console.WriteLine();
		}
	}
}
