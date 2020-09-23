using System;
using System.Collections.Generic;
using System.Text;

namespace RSPLS
{
	class Ai : Player
	{
		// Member Variables
		public Gesture gestures;


		// Constructor
		public Ai()
		{
			gestures = new Gesture();
		}

		// Member Methods
		public override string GestureSelection()
		{
			Random aiGestureRoll = new Random();
			int userGesture = aiGestureRoll.Next(gestures.gestureListAttacks.Count);
			Console.WriteLine($"The AI player has thrown {gestures.gestureList[userGesture].gesture}!");
			if (userGesture == 0)
			{
				gest = gestures.rock.gesture;
				return gest;
			}
			else if (userGesture == 1)
			{
				gest = gestures.paper.gesture;
				return gest;

			}
			else if (userGesture == 2)
			{
				gest = gestures.scissors.gesture;
				return gest;
			}
			else if (userGesture == 3)
			{
				gest = gestures.lizard.gesture;
				return gest;
			}
			else if (userGesture == 4)
			{
				gest = gestures.spock.gesture;
				return gest;
			}
			else if (userGesture == 5)
			{
				gest = gestures.spiderman.gesture;
				return gest;
			}
			else if (userGesture == 6)
			{
				gest = gestures.batman.gesture;
				return gest;
			}
			else if (userGesture == 7)
			{
				gest = gestures.wizard.gesture;
				return gest;
			}
			else if (userGesture == 8)
			{
				gest = gestures.glock.gesture;
				return gest;
			}
			else
			{
				string aiGesture = "Re-rolling.";
				return aiGesture;
			}
		}

	}
}
