using System;
using System.Collections.Generic;
using System.Text;

namespace RSPLS
{
	class Human : Player
	{
		// Member Variables
		public Gesture gestures;

		// Constructor
		public Human()
		{
			gestures = new Gesture();
		}

		// Member Methods
		// Capture User Input
		public override void GestureSelection()
		{
			//Console.WriteLine("Please choose a number or gesture from the selection below!");
			//var userChoice = Console.ReadLine();
		}

	}
}
