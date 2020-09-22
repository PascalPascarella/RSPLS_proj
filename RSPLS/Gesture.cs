using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace RSPLS
{
	class Gesture
	{


		// Member Variables
		public GestureFab rock;
		public GestureAttacks rockAttack;
		public GestureFab paper;
		public GestureAttacks paperAttack;
		public GestureFab scissors;
		public GestureAttacks scissorsAttack;
		public GestureFab lizard;
		public GestureAttacks lizardAttack;
		public GestureFab spock;
		public GestureAttacks spockAttack;
		public GestureFab spiderman;
		public GestureAttacks spidermanAttack;
		public GestureFab batman;
		public GestureAttacks batmanAttack;
		public GestureFab wizard;
		public GestureAttacks wizardAttack;
		public GestureFab glock;
		public GestureAttacks glockAttack;

		public List<GestureFab> gestureList;
		public List<GestureAttacks> gestureListAttacks;



		// Constructor
		public Gesture()
		{
			gestureList = new List<GestureFab>();
			gestureListAttacks = new List<GestureAttacks>();
			// Efficiency Testing with Dictionary
			rock = new GestureFab()
			{
				ID = 1,
				gesture = "Rock",
				gestureAlt = "rock",
			};
			rockAttack = new GestureAttacks()
			{
				ID = 1,
				attack1 = "Rock smashes Lizard!",
				attack2 = "Rock blocks Wizard!",
				attack3 = "Rock crushes Scissors!",
				attack4 = "Rock falls on Spiderman!",
			};
			paper = new GestureFab()
			{
				ID = 2,
				gesture = "Paper",
				gestureAlt = "paper",
			};
			paperAttack = new GestureAttacks()
			{
				ID = 2,
				attack1 = "Paper engulfs Rock!",
				attack2 = "Paper disproves Spock!",
				attack3 = "Paper says Glock missed!",
				attack4 = "Paper trail misleads Batman!",
			};
			scissors = new GestureFab()
			{
				ID = 3,
				gesture = "Scissors",
				gestureAlt = "scissors",
			};
			scissorsAttack = new GestureAttacks()
			{
				ID = 3,
				attack1 = "Scissors cut Paper!",
				attack2 = "Scissors destroy Wizard's robe!",
				attack3 = "Scissors slice off Lizard's tail!",
				attack4 = "Scissors cut Spiderman's web!",
			};
			lizard = new GestureFab()
			{
				ID = 4,
				gesture = "Lizard",
				gestureAlt = "lizard",
			};
			lizardAttack = new GestureAttacks()
			{
				ID = 4,
				attack1 = "Lizard poisons Spock",
				attack2 = "Lizard looks like Killer Croc and confuses Batman!",
				attack3 = "Lizard eats Paper!",
				attack4 = "Lizard is too small for Glock!",
			};
			spock = new GestureFab()
			{
				ID = 5,
				gesture = "Spock",
				gestureAlt = "spock",
			};
			spockAttack = new GestureAttacks()
			{
				ID = 5,
				attack1 = "Spock stuns Wizard!",
				attack2 = "Spock leaves Spiderman starstruck!",
				attack3 = "Spock vaporizes Rock!",
				attack4 = "Spock's haircut is too perfect for Scissors!",
			};
			spiderman = new GestureFab()
			{
				ID = 6,
				gesture = "Spiderman",
				gestureAlt = "spiderman",
			};
			spidermanAttack = new GestureAttacks()
			{
				ID = 6,
				attack1 = "Spiderman thwips Glock",
				attack2 = "Spiderman catches Lizard for science class!",
				attack3 = "Spiderman overtakes Paper's front page!",
				attack4 = "Spiderman confuses Wizard!",
			};
			batman = new GestureFab()
			{
				ID = 7,
				gesture = "Batman",
				gestureAlt = "batman",
			};
			batmanAttack = new GestureAttacks()
			{
				ID = 7,
				attack1 = "Batman's stack of money crushes Spiderman!",
				attack2 = "Batman dismantles Scissors for analysis!",
				attack3 = "Batman pellet grenades blast through Rock!",
				attack4 = "Batman trips-up Spock!",
			};
			wizard = new GestureFab()
			{
				ID = 8,
				gesture = "Wizard",
				gestureAlt = "wizard",
			};
			wizardAttack = new GestureAttacks()
			{
				ID = 8,
				attack1 = "Wizard blinds Batman!",
				attack2 = "Wizard burns Paper!",
				attack3 = "Wizard transforms Lizard!",
				attack4 = "Wizard deflects Glock!",
			};
			glock = new GestureFab()
			{
				ID = 9,
				gesture = "Glock",
				gestureAlt = "glock",
			};
			glockAttack = new GestureAttacks()
			{
				ID = 9,
				attack1 = "Glock cracks Rock!",
				attack2 = "Glock kills Batman's parents!",
				attack3 = "Glock destroys Spock's faith in Humanity!",
				attack4 = "Glock dents Scissors!",
			};

			gestureList.Add(rock);
			gestureList.Add(paper);
			gestureList.Add(scissors);
			gestureList.Add(lizard);
			gestureList.Add(spock);
			gestureList.Add(spiderman);
			gestureList.Add(batman);
			gestureList.Add(wizard);
			gestureList.Add(glock);

			gestureListAttacks.Add(rockAttack);
			gestureListAttacks.Add(paperAttack);
			gestureListAttacks.Add(scissorsAttack);
			gestureListAttacks.Add(lizardAttack);
			gestureListAttacks.Add(spockAttack);
			gestureListAttacks.Add(spidermanAttack);
			gestureListAttacks.Add(batmanAttack);
			gestureListAttacks.Add(wizardAttack);
			gestureListAttacks.Add(glockAttack);
		}

		// Member Methods
		// Print Gesture List
		public void PrintGestureList()
		{
			foreach (GestureFab i in gestureList)
			Console.WriteLine(i.gesture);
		}
		// Print Attack List
		public void PrintAttackList()
		{
			foreach (GestureAttacks i in gestureListAttacks)
				Console.WriteLine($"{i.attack1} \n{i.attack2} \n{i.attack3} \n{i.attack4}\n");
		}
		//// Condense Gesture And Value Lists
		//public void ListsCondense()
		//{
		//	var valuesAndGestures = gestureValues.Zip(gestureStrings, (value, gesture) => value + " " + gesture);		// Merges 2 lists into referenced coordinate system with [n] returning the nth index from each list (ex: [0] = <1 rock>).
		//	foreach (var item in valuesAndGestures)
		//	{
		//		Console.WriteLine(item);
		//	}
		//}
		//// What Gesture Is Able To Attack Another
		//public void PrintAttackListRock()
		//{
		//	foreach (var item in rockAttacks)
		//	{
		//		Console.WriteLine(item);

		//	}

		//}
		//public void PrintAttackListPaper()
		//{
		//	foreach (var item in paperAttacks)
		//	{
		//		Console.WriteLine(item);

		//	}
		//}
		//public void PrintAttackListScissors()
		//{
		//	foreach (var item in scissorsAttacks)
		//	{
		//		Console.WriteLine(item);

		//	}

		//}
		//public void PrintAttackListLizard()
		//{
		//	foreach (var item in lizardAttacks)
		//	{
		//		Console.WriteLine(item);

		//	}

		//}
		//public void PrintAttackListSpock()
		//{
		//	foreach (var item in spockAttacks)
		//	{
		//		Console.WriteLine(item);

		//	}
		//}
		//public void PrintAttackListSpiderman()
		//{
		//	foreach (var item in spidermanAttacks)
		//	{
		//		Console.WriteLine(item);

		//	}

		//}
		//public void PrintAttackListBatman()
		//{
		//	foreach (var item in batmanAttacks)
		//	{
		//		Console.WriteLine(item);

		//	}

		//}
		//public void PrintAttackListWizard()
		//{
		//	foreach (var item in wizardAttacks)
		//	{
		//		Console.WriteLine(item);

		//	}
		//}
		//public void PrintAttackListGlock()
		//{
		//	foreach (var item in glockAttacks)
		//	{
		//		Console.WriteLine(item);

		//	}
		//}
	}
}
