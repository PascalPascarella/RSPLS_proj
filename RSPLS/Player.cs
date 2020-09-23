using System;
using System.Collections.Generic;
using System.Text;

namespace RSPLS
{
	abstract class Player
	{
		// Member Variables
		public Gesture gesture;
		public int score;
		public int userGesture;
		public string gest;

		// Constructor
		public Player()
		{

		}

		// Member Methods
		public abstract string GestureSelection();


	}
}
