using System;
using System.Collections.Generic;
using System.Text;

namespace RSPLS
{
	class Human : Player
	{
		// Member Variables
		public Gesture gestures;
		public string userGesture;

		// Constructor
		public Human()
		{
			gestures = new Gesture();
		}

		// Member Methods
		// Capture User Input
		public override string GestureSelection()
		{
			Console.WriteLine("Please choose a number or gesture from the selection below!");
			gestures.PrintGestureSelection();

			string userGesture = Console.ReadLine();
			return userGesture;
		}

	}
}
