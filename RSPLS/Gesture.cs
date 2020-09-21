using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
		public List<string> gestureAttacks;
		public List<string> rockAttacks;
		public List<string> paperAttacks;
		public List<string> scissorsAttacks;
		public List<string> lizardAttacks;
		public List<string> spockAttacks;
		public List<string> spidermanAttacks;
		public List<string> batmanAttacks;
		public List<string> wizardAttacks;
		public List<string> glockAttacks;

		public string rockBeatLizard;
		public string rockBeatWizard;
		public string rockBeatScissors;
		public string rockBeatSpiderman;
		public string paperBeatRock;
		public string paperBeatSpock;
		public string paperBeatGlock;
		public string paperBeatBatman;
		public string scissorsBeatPaper;
		public string scissorsBeatWizard;
		public string scissorsBeatLizard;
		public string scissorsBeatSpiderman;
		public string lizardBeatSpock;
		public string lizardBeatBatman;
		public string lizardBeatPaper;
		public string lizardBeatGlock;
		public string spockBeatWizard;
		public string spockBeatSpiderman;
		public string spockBeatRock;
		public string spockBeatScissors;
		public string spidermanBeatGlock;
		public string spidermanBeatLizard;
		public string spidermanBeatPaper;
		public string spidermanBeatWizard;
		public string batmanBeatSpiderman;
		public string batmanBeatScissors;
		public string batmanBeatRock;
		public string batmanBeatSpock;
		public string wizardBeatBatman;
		public string wizardBeatPaper;
		public string wizardBeatLizard;
		public string wizardBeatGlock;
		public string glockBeatRock;
		public string glockBeatBatman;
		public string glockBeatSpock;
		public string glockBeatScissors;


		// Constructor
		public Gesture()
		{
			this.rock = "Rock";
			this.paper = "Paper";
			this.scissors = "Scissors";
			this.lizard = "Lizard";
			this.spock = "Spock";
			this.spiderman = "Spiderman";
			this.batman = "Batman";
			this.wizard = "Wizard";
			this.glock = "Glock";

			// Attack Phrases
			this.rockBeatLizard = "Rock smashes Lizard!";
			this.rockBeatWizard = "Rock blocks Wizard!";
			this.rockBeatScissors = "Rock crushes Scissors!";
			this.rockBeatSpiderman = "Rock falls on Spiderman!";
			this.paperBeatRock = "Paper engulfs Rock!";
			this.paperBeatSpock = "Paper disproves Spock!";
			this.paperBeatGlock = "Paper says Glock missed!";
			this.paperBeatBatman = "Paper trail misleads Batman!";
			this.scissorsBeatPaper = "Scissors cut Paper!";
			this.scissorsBeatWizard = "Scissors destroy Wizard's robe!";
			this.scissorsBeatLizard = "Scissors slice off Lizard's tail!";
			this.scissorsBeatSpiderman = "Scissors cut Spiderman's web!";
			this.lizardBeatSpock = "Lizard poisons Spock";
			this.lizardBeatBatman = "Lizard looks like Killer Croc and confuses Batman!";
			this.lizardBeatPaper = "Lizard eats Paper!";
			this.lizardBeatGlock = "Lizard is too small for Glock!";
			this.spockBeatWizard = "Spock stuns Wizard!";
			this.spockBeatSpiderman = "Spock leaves Spiderman starstruck!";
			this.spockBeatRock = "Spock vaporizes Rock!";
			this.spockBeatScissors = "Spock's haircut is too perfect for Scissors!";
			this.spidermanBeatGlock = "Spiderman thwips Glock";
			this.spidermanBeatLizard = "Spiderman catches Lizard for science class!";
			this.spidermanBeatPaper = "Spiderman overtakes Paper's front page!";
			this.spidermanBeatWizard = "Spiderman confuses Wizard!";
			this.batmanBeatSpiderman = "Batman's stack of money crushes Spiderman!";
			this.batmanBeatScissors = "Batman dismantles Scissors for analysis!";
			this.batmanBeatRock = "Batman pellet grenades blast through Rock!";
			this.batmanBeatSpock = "Batman trips-up Spock!";
			this.wizardBeatBatman = "Wizard blinds Batman!";
			this.wizardBeatPaper = "Wizard burns Paper!";
			this.wizardBeatLizard = "Wizard transforms Lizard!";
			this.wizardBeatGlock = "Wizard deflects Glock!";
			this.glockBeatRock = "Glock cracks Rock!";
			this.glockBeatBatman = "Glock kills Batman's parents!";
			this.glockBeatSpock = "Glock destroys Spock's faith in Humanity!";
			this.glockBeatScissors = "Glock dents Scissors!";

			// Lists
			gestureStrings = new List<string>();
			gestureValues = new List<int>();
			gestureAttacks = new List<string>();

			gestureStrings.Add(rock);
			gestureStrings.Add(paper);
			gestureStrings.Add(scissors);
			gestureStrings.Add(lizard);
			gestureStrings.Add(spock);
			gestureStrings.Add(spiderman);
			gestureStrings.Add(batman);
			gestureStrings.Add(wizard);
			gestureStrings.Add(glock);

			gestureValues.Add(1);
			gestureValues.Add(2);
			gestureValues.Add(3);
			gestureValues.Add(4);
			gestureValues.Add(5);
			gestureValues.Add(6);
			gestureValues.Add(7);
			gestureValues.Add(8);
			gestureValues.Add(9);

			gestureAttacks.Add(rockBeatLizard);
			gestureAttacks.Add(rockBeatWizard);
			gestureAttacks.Add(rockBeatScissors);
			gestureAttacks.Add(rockBeatSpiderman);
			gestureAttacks.Add(paperBeatRock);
			gestureAttacks.Add(paperBeatSpock);
			gestureAttacks.Add(paperBeatGlock);
			gestureAttacks.Add(paperBeatBatman);
			gestureAttacks.Add(scissorsBeatPaper);
			gestureAttacks.Add(scissorsBeatWizard);
			gestureAttacks.Add(scissorsBeatLizard);
			gestureAttacks.Add(scissorsBeatSpiderman);
			gestureAttacks.Add(lizardBeatSpock);
			gestureAttacks.Add(lizardBeatBatman);
			gestureAttacks.Add(lizardBeatPaper);
			gestureAttacks.Add(lizardBeatGlock);
			gestureAttacks.Add(spockBeatWizard);
			gestureAttacks.Add(spockBeatSpiderman);
			gestureAttacks.Add(spockBeatRock);
			gestureAttacks.Add(spockBeatScissors);
			gestureAttacks.Add(spidermanBeatGlock);
			gestureAttacks.Add(spidermanBeatLizard);
			gestureAttacks.Add(spidermanBeatPaper);
			gestureAttacks.Add(spidermanBeatWizard);
			gestureAttacks.Add(batmanBeatSpiderman);
			gestureAttacks.Add(batmanBeatScissors);
			gestureAttacks.Add(batmanBeatRock);
			gestureAttacks.Add(batmanBeatSpock);
			gestureAttacks.Add(wizardBeatBatman);
			gestureAttacks.Add(wizardBeatPaper);
			gestureAttacks.Add(wizardBeatLizard);
			gestureAttacks.Add(wizardBeatGlock);
			gestureAttacks.Add(glockBeatRock);
			gestureAttacks.Add(glockBeatBatman);
			gestureAttacks.Add(glockBeatSpock);
			gestureAttacks.Add(glockBeatScissors);
		}

		// Member Methods
		// Print Gesture List
		public void PrintGestureList()
		{
			foreach (string i in gestureStrings)
			Console.WriteLine(i);
		}
		// Print Attack List
		public void PrintAttackList()
		{
			foreach (string i in gestureAttacks)
				Console.WriteLine(i);
		}
		// Condense Gesture And Value Lists
		public void ListsCondense()
		{
			var valuesAndGestures = gestureValues.Zip(gestureStrings, (value, gesture) => value + " " + gesture);		// Merges 2 lists into referenced coordinate system with [n] returning the nth index from each list (ex: [0] = <1 rock>).
			foreach (var item in valuesAndGestures)
			{
				Console.WriteLine(item);

			}
		}
		// What Gesture Is Able To Another
		public void PrintAttackListRock()
		{

		}
		public void PrintAttackListPaper()
		{

		}
		public void PrintAttackListScissors()
		{

		}
		public void PrintAttackListLizard()
		{

		}
		public void PrintAttackListSpock()
		{

		}
		public void PrintAttackListSpiderman()
		{

		}
		public void PrintAttackListBatman()
		{

		}
		public void PrintAttackListWizard()
		{

		}
		public void PrintAttackListGlock()
		{

		}
	}
}
