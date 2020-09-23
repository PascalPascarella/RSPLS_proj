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
		public override string GestureSelection()
		{
			Console.WriteLine("Please choose a number or gesture from the selection below!");
			gestures.PrintGestureSelection();

			int userGesture = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"Player has thrown {gestures.gestureList[userGesture].gesture}!");
			if (userGesture == gestures.rock.ID)
			{
				gest = gestures.rock.gesture;
				return gest;
			}
			else if (userGesture == gestures.paper.ID)
			{
				gest = gestures.paper.gesture;
				return gest;
			}
			else if (userGesture == gestures.scissors.ID)
			{
				gest = gestures.scissors.gesture;
				return gest;
			}
			else if (userGesture == gestures.lizard.ID)
			{
				gest = gestures.lizard.gesture;
				return gest;
			}
			else if (userGesture == gestures.spock.ID)
			{
				gest = gestures.spock.gesture;
				return gest;
			}
			else if (userGesture == gestures.spiderman.ID)
			{
				gest = gestures.spiderman.gesture;
				return gest;
			}
			else if (userGesture == gestures.batman.ID)
			{
				gest = gestures.batman.gesture;
				return gest;
			}
			else if (userGesture == gestures.wizard.ID)
			{
				gest = gestures.wizard.gesture;
				return gest;
			}
			else if (userGesture == gestures.glock.ID)
			{
				gest = gestures.glock.gesture;
				return gest;
			}
			else
			{
				return Convert.ToString(userGesture);
			}
		}
	}
}
