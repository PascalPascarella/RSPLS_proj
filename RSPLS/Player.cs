using System;
using System.Collections.Generic;
using System.Text;

namespace RSPLS
{
	abstract class Player
	{
		// Member Variables
		public ValueTuple gestureValuePair;
		public int score;


		// Constructor
		public Player()
		{

		}

		// Member Methods
		public abstract void GestureSelection();


	}
}
