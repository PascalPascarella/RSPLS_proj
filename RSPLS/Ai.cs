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
			int roll = aiGestureRoll.Next(gestures.gestureListAttacks.Count);
			Console.WriteLine($"The AI player has thrown {gestures.gestureList[roll].gesture}");
			if (roll == 0)
			{
				return gestures.rock.gesture;
				Console.WriteLine(gestures.rock.gesture);
			}
			else if (roll == 1)
			{
				return gestures.paper.gesture;

			}
			else if (roll == 2)
			{
				return gestures.scissors.gesture;
			}
			else if (roll == 3)
			{
				return gestures.lizard.gesture;
			}
			else if (roll == 4)
			{
				return gestures.spock.gesture;
			}
			else if (roll == 5)
			{
				return gestures.spiderman.gesture;
			}
			else if (roll == 6)
			{
				return gestures.batman.gesture;
			}
			else if (roll == 7)
			{
				return gestures.wizard.gesture;
			}
			else if (roll == 8)
			{
				return gestures.glock.gesture;
			}
			else
			{
				string aiGesture = "Re-rolling.";
				return aiGesture;
				GestureSelection();
			}
		}

	}
}
