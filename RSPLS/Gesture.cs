using System;
using System.Collections.Generic;
using System.Text;

namespace RSPLS
{
	class Gesture
	{
		// Member Variables
		public string rock;
		public string paper;
		public string scissors;
		public string lizard;
		public string spock;
		public string spiderman;
		public string batman;
		public string wizard;
		public string glock;
		public List<string> gestureStrings;
		public List<int> gestureValues;

		// Constructor
		public Gesture()
		{
			gestureStrings = new List<string>();
			this.rock = "Rock";
			this.paper = "Paper";
			this.scissors = "Scissors";
			this.lizard = "Lizard";
			this.spock = "Spock";
			this.spiderman = "Spiderman";
			this.batman = "Batman";
			this.wizard = "Wizard";
			this.glock = "Glock";
			gestureStrings.Add(rock);
			gestureStrings.Add(paper);
			gestureStrings.Add(scissors);
			gestureStrings.Add(lizard);
			gestureStrings.Add(spock);
			gestureStrings.Add(spiderman);
			gestureStrings.Add(batman);
			gestureStrings.Add(wizard);
			gestureStrings.Add(glock);
		}

		// Member Methods
		// Print Gesture List
		public void PrintGestureList()
		{
			foreach (var i in gestureStrings)
			Console.WriteLine(i);
		}
		// Print Attack List
		public void PrintAttackList()
		{

		}

	}
}
