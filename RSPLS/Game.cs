using System;
using System.Collections.Generic;
using System.Text;

namespace RSPLS
{
	class Game
	{
		// Member Variables


		// Constructor
		public Game()
		{

		}

		// Member Methods
		// Main
		public void GameRun()
		{
			PlayerGreeting();
		}

		// Greeting
		public void PlayerGreeting()
		{
			Console.WriteLine("Welcome to Rock-Scissors-Paper-Lizard-Spock!");
		}
	}
}
