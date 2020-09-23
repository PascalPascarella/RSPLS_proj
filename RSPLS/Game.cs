using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace RSPLS
{
	class Game
	{
		// Member Variables
		public Player player1;
		public Player player2;
		public Gesture gestures;
		public int winningScore;
		public int userInputRules;
		public bool viewRules;
		public bool viewListAttacks;
		public bool rematch;



		// Constructor
		public Game()
		{

			player1 = new Human();
			gestures = new Gesture();
			winningScore = 3;

		}

		// Member Methods
		// Main
		public void GameRun()
		{
			PlayerGreeting();     // Greets user(s) and ...
			gestures.PrintGestureList();			// Welcomes them with the list of gestures as the name of the game
			Console.WriteLine("\n");
			ViewRules();			// User can opt in or out of viewing rules
			GameTypeSelect();     // User selects how many players and type

			while (player1.score < winningScore && player2.score < winningScore)      // Rounds Start
			{
				PrintScore();
				Console.WriteLine("\n\nPlayer 1:");
				player1.GestureSelection();     // Captures Player 1's throw
				/*Refresher();*/      // Screen Refresh
				Console.WriteLine("\n\nPlayer 2:");
				player2.GestureSelection();			// Captures Player 2's throw
				GestureCompare();     // Decides who wins a certain round of RPSLSSBWG
				PrintVictor();     // Declare Victor
			}
			Rematch();      // Play Again
											// --> TODO: Add Custom Gestures?
			Console.ReadLine();
		}

		// Greeting
		public void PlayerGreeting()
		{
			Console.WriteLine("Welcome to...");
			Console.WriteLine();
		}

		// View Rules
		public void ViewRules()
		{
			// --> Type out if curious to see rules or what beats what
			Console.Write("Would you like to browse the entire list of attacks (Y/N)? ");
			string userChoice = Console.ReadLine();
			while (viewRules == false)
			{
				if (userChoice == "y" || userChoice == "Y" || userChoice == "yes" || userChoice == "Yes")
				{
					Console.Clear();
					Console.WriteLine("\nBest 3 out of 5.");
					Console.WriteLine("ATTACK STRENGTHS: \n");
					gestures.PrintAttackList();
					Refresher();			// Screen Refresh
					viewRules = true;
				}
				else if (userChoice == "n" || userChoice == "N" || userChoice == "no" || userChoice == "No")
				{
					Console.Clear();
					Console.WriteLine("Well alllllllrighty then, Mr. Smarty-Pants. Let us begin the game. \n");
					Refresher(); 			// Screen Refresh
					viewRules = true;
				}
				else
				{
					Console.WriteLine("Apologies, User. I do not speak gibberish. Please enter 'yes' or 'no': ");
					userChoice = Console.ReadLine();
				}
			}
		}

		// Gesture Comparison
		public void GestureCompare()
		{	// Look into switch cases instead of if-else
			if (player1.gest == player2.gest)
			{
				Console.WriteLine($"Both players rolled a {player1.gest}");
			}
			// Player 1 options
			else if ((player1.gest == (gestures.rock.gesture)) &&			// Player 1 chooses "Rock"
				(player2.gest == (gestures.lizard.gesture) ||
				player2.gest == (gestures.wizard.gesture) ||
				player2.gest == (gestures.scissors.gesture) ||
				player2.gest == (gestures.spiderman.gesture)))
			{
				if (player2.gest == (gestures.lizard.gesture))
				{
					Console.WriteLine(gestures.rockAttack.attack1);
				}
				else if (player2.gest == (gestures.wizard.gesture))
				{
					Console.WriteLine(gestures.rockAttack.attack2);
				}
				else if (player2.gest == (gestures.scissors.gesture))
				{
					Console.WriteLine(gestures.rockAttack.attack3);
				}
				else if (player2.gest == (gestures.spiderman.gesture))
				{
					Console.WriteLine(gestures.rockAttack.attack4);
				}
				player1.score++;
			}
			else if ((player1.gest == (gestures.paper.gesture)) &&      // Player 1 chooses "Paper"
				(player2.gest == (gestures.rock.gesture) ||
				player2.gest == (gestures.spock.gesture) ||
				player2.gest == (gestures.glock.gesture) ||
				player2.gest == (gestures.batman.gesture)))
			{
				if (player2.gest == (gestures.rock.gesture))
				{
					Console.WriteLine(gestures.paperAttack.attack1);
				}
				else if (player2.gest == (gestures.spock.gesture))
				{
					Console.WriteLine(gestures.paperAttack.attack2);
				}
				else if (player2.gest == (gestures.glock.gesture))
				{
					Console.WriteLine(gestures.paperAttack.attack3);
				}
				else if (player2.gest == (gestures.batman.gesture))
				{
					Console.WriteLine(gestures.paperAttack.attack4);
				}
				player1.score++;
			}
			else if ((player1.gest == (gestures.scissors.gesture)) &&     // Player 1 chooses "Scissors"
				(player2.gest == (gestures.paper.gesture) ||
				player2.gest == (gestures.wizard.gesture) ||
				player2.gest == (gestures.lizard.gesture) ||
				player2.gest == (gestures.spiderman.gesture)))
			{
				if (player2.gest == (gestures.paper.gesture))
				{
					Console.WriteLine(gestures.scissorsAttack.attack1);
				}
				else if (player2.gest == (gestures.wizard.gesture))
				{
					Console.WriteLine(gestures.scissorsAttack.attack2);
				}
				else if (player2.gest == (gestures.lizard.gesture))
				{
					Console.WriteLine(gestures.scissorsAttack.attack3);
				}
				else if (player2.gest == (gestures.spiderman.gesture))
				{
					Console.WriteLine(gestures.scissorsAttack.attack4);
				}
				player1.score++;
			}
			else if ((player1.gest == (gestures.lizard.gesture)) &&     // Player 1 chooses "Lizard"
				(player2.gest == (gestures.spock.gesture) ||
				player2.gest == (gestures.batman.gesture) ||
				player2.gest == (gestures.paper.gesture) ||
				player2.gest == (gestures.glock.gesture)))
			{
				if (player2.gest == (gestures.spock.gesture))
				{
					Console.WriteLine(gestures.lizardAttack.attack1);
				}
				else if (player2.gest == (gestures.batman.gesture))
				{
					Console.WriteLine(gestures.lizardAttack.attack2);
				}
				else if (player2.gest == (gestures.paper.gesture))
				{
					Console.WriteLine(gestures.lizardAttack.attack3);
				}
				else if (player2.gest == (gestures.glock.gesture))
				{
					Console.WriteLine(gestures.lizardAttack.attack4);
				}
				player1.score++;
			}
			else if ((player1.gest == (gestures.spock.gesture)) &&      // Player 1 chooses "Spock"
				(player2.gest == (gestures.wizard.gesture) ||
				player2.gest == (gestures.spiderman.gesture) ||
				player2.gest == (gestures.rock.gesture) ||
				player2.gest == (gestures.scissors.gesture)))
			{
				if (player2.gest == (gestures.wizard.gesture))
				{
					Console.WriteLine(gestures.spockAttack.attack1);
				}
				else if (player2.gest == (gestures.spiderman.gesture))
				{
					Console.WriteLine(gestures.spockAttack.attack2);
				}
				else if (player2.gest == (gestures.rock.gesture))
				{
					Console.WriteLine(gestures.spockAttack.attack3);
				}
				else if (player2.gest == (gestures.scissors.gesture))
				{
					Console.WriteLine(gestures.spockAttack.attack4);
				}
				player1.score++;
			}
			else if ((player1.gest == (gestures.spiderman.gesture)) &&      // Player 1 chooses "Spiderman"
				(player2.gest == (gestures.glock.gesture) ||
				player2.gest == (gestures.lizard.gesture) ||
				player2.gest == (gestures.paper.gesture) ||
				player2.gest == (gestures.wizard.gesture)))
			{
				if (player2.gest == (gestures.glock.gesture))
				{
					Console.WriteLine(gestures.spidermanAttack.attack1);
				}
				else if (player2.gest == (gestures.lizard.gesture))
				{
					Console.WriteLine(gestures.spidermanAttack.attack2);
				}
				else if (player2.gest == (gestures.paper.gesture))
				{
					Console.WriteLine(gestures.spidermanAttack.attack3);
				}
				else if (player2.gest == (gestures.wizard.gesture))
				{
					Console.WriteLine(gestures.spidermanAttack.attack4);
				}
				player1.score++;
			}
			else if ((player1.gest == (gestures.batman.gesture)) &&     // Player 1 chooses "Batman"
				(player2.gest == (gestures.spiderman.gesture) ||
				player2.gest == (gestures.scissors.gesture) ||
				player2.gest == (gestures.rock.gesture) ||
				player2.gest == (gestures.spock.gesture)))
			{
				if (player2.gest == (gestures.spiderman.gesture))
				{
					Console.WriteLine(gestures.batmanAttack.attack1);
				}
				else if (player2.gest == (gestures.scissors.gesture))
				{
					Console.WriteLine(gestures.batmanAttack.attack2);
				}
				else if (player2.gest == (gestures.rock.gesture))
				{
					Console.WriteLine(gestures.batmanAttack.attack3);
				}
				else if (player2.gest == (gestures.spock.gesture))
				{
					Console.WriteLine(gestures.batmanAttack.attack4);
				}
				player1.score++;
			}
			else if ((player1.gest == (gestures.wizard.gesture)) &&     // Player 1 chooses "Wizard"
				(player2.gest == (gestures.batman.gesture) ||
				player2.gest == (gestures.paper.gesture) ||
				player2.gest == (gestures.lizard.gesture) ||
				player2.gest == (gestures.glock.gesture)))
			{
				if (player2.gest == (gestures.batman.gesture))
				{
					Console.WriteLine(gestures.wizardAttack.attack1);
				}
				else if (player2.gest == (gestures.paper.gesture))
				{
					Console.WriteLine(gestures.wizardAttack.attack2);
				}
				else if (player2.gest == (gestures.lizard.gesture))
				{
					Console.WriteLine(gestures.wizardAttack.attack3);
				}
				else if (player2.gest == (gestures.glock.gesture))
				{
					Console.WriteLine(gestures.wizardAttack.attack4);
				}
				player1.score++;
			}
			else if ((player1.gest == (gestures.glock.gesture)) &&      // Player 1 chooses "Glock"
				(player2.gest == (gestures.rock.gesture) ||
				player2.gest == (gestures.batman.gesture) ||
				player2.gest == (gestures.spock.gesture) ||
				player2.gest == (gestures.scissors.gesture)))
			{
				if (player2.gest == (gestures.rock.gesture))
				{
					Console.WriteLine(gestures.glockAttack.attack1);
				}
				else if (player2.gest == (gestures.batman.gesture))
				{
					Console.WriteLine(gestures.glockAttack.attack2);
				}
				else if (player2.gest == (gestures.spock.gesture))
				{
					Console.WriteLine(gestures.glockAttack.attack3);
				}
				else if (player2.gest == (gestures.scissors.gesture))
				{
					Console.WriteLine(gestures.glockAttack.attack4);
				}
				player1.score++;
			}
			// Player 2 options
			else if ((player2.gest == (gestures.rock.gesture)) &&     // Player 2 chooses "Rock"
				(player1.gest == (gestures.lizard.gesture) ||
				player1.gest == (gestures.wizard.gesture) ||
				player1.gest == (gestures.scissors.gesture) ||
				player1.gest == (gestures.spiderman.gesture)))
			{
				if (player1.gest == (gestures.lizard.gesture))
				{
					Console.WriteLine(gestures.rockAttack.attack1);
				}
				else if (player1.gest == (gestures.wizard.gesture))
				{
					Console.WriteLine(gestures.rockAttack.attack2);
				}
				else if (player1.gest == (gestures.scissors.gesture))
				{
					Console.WriteLine(gestures.rockAttack.attack3);
				}
				else if (player1.gest == (gestures.spiderman.gesture))
				{
					Console.WriteLine(gestures.rockAttack.attack4);
				}
				player2.score++;
			}
			else if ((player2.gest == (gestures.paper.gesture)) &&     // Player 2 chooses "Paper"
				(player1.gest == (gestures.rock.gesture) ||
				player1.gest == (gestures.spock.gesture) ||
				player1.gest == (gestures.glock.gesture) ||
				player1.gest == (gestures.batman.gesture)))
			{
				if (player1.gest == (gestures.rock.gesture))
				{
					Console.WriteLine(gestures.paperAttack.attack1);
				}
				else if (player1.gest == (gestures.spock.gesture))
				{
					Console.WriteLine(gestures.paperAttack.attack2);
				}
				else if (player1.gest == (gestures.glock.gesture))
				{
					Console.WriteLine(gestures.paperAttack.attack3);
				}
				else if (player1.gest == (gestures.batman.gesture))
				{
					Console.WriteLine(gestures.paperAttack.attack4);
				}
				player2.score++;
			}
			else if ((player2.gest == (gestures.scissors.gesture)) &&     // Player 2 chooses "Scissors"
				(player1.gest == (gestures.paper.gesture) ||
				player1.gest == (gestures.wizard.gesture) ||
				player1.gest == (gestures.lizard.gesture) ||
				player1.gest == (gestures.spiderman.gesture)))
			{
				if (player1.gest == (gestures.paper.gesture))
				{
					Console.WriteLine(gestures.scissorsAttack.attack1);
				}
				else if (player1.gest == (gestures.wizard.gesture))
				{
					Console.WriteLine(gestures.scissorsAttack.attack2);
				}
				else if (player1.gest == (gestures.lizard.gesture))
				{
					Console.WriteLine(gestures.scissorsAttack.attack3);
				}
				else if (player1.gest == (gestures.spiderman.gesture))
				{
					Console.WriteLine(gestures.scissorsAttack.attack4);
				}
				player2.score++;
			}
			else if ((player2.gest == (gestures.lizard.gesture)) &&     // Player 2 chooses "Lizard"
				(player1.gest == (gestures.spock.gesture) ||
				player1.gest == (gestures.batman.gesture) ||
				player1.gest == (gestures.paper.gesture) ||
				player1.gest == (gestures.glock.gesture)))
			{
				if (player1.gest == (gestures.spock.gesture))
				{
					Console.WriteLine(gestures.lizardAttack.attack1);
				}
				else if (player1.gest == (gestures.batman.gesture))
				{
					Console.WriteLine(gestures.lizardAttack.attack2);
				}
				else if (player1.gest == (gestures.paper.gesture))
				{
					Console.WriteLine(gestures.lizardAttack.attack3);
				}
				else if (player1.gest == (gestures.glock.gesture))
				{
					Console.WriteLine(gestures.lizardAttack.attack4);
				}
				player2.score++;
			}
			else if ((player2.gest == (gestures.spock.gesture)) &&     // Player 2 chooses "Spock"
				(player1.gest == (gestures.wizard.gesture) ||
				player1.gest == (gestures.spiderman.gesture) ||
				player1.gest == (gestures.rock.gesture) ||
				player1.gest == (gestures.scissors.gesture)))
			{
				if (player1.gest == (gestures.wizard.gesture))
				{
					Console.WriteLine(gestures.spockAttack.attack1);
				}
				else if (player1.gest == (gestures.spiderman.gesture))
				{
					Console.WriteLine(gestures.spockAttack.attack2);
				}
				else if (player1.gest == (gestures.rock.gesture))
				{
					Console.WriteLine(gestures.spockAttack.attack3);
				}
				else if (player1.gest == (gestures.scissors.gesture))
				{
					Console.WriteLine(gestures.spockAttack.attack4);
				}
				player2.score++;
			}
			else if ((player2.gest == (gestures.spiderman.gesture)) &&     // Player 2 chooses "Spiderman"
				(player1.gest == (gestures.glock.gesture) ||
				player1.gest == (gestures.lizard.gesture) ||
				player1.gest == (gestures.paper.gesture) ||
				player1.gest == (gestures.wizard.gesture)))
			{
				if (player1.gest == (gestures.glock.gesture))
				{
					Console.WriteLine(gestures.spidermanAttack.attack1);
				}
				else if (player1.gest == (gestures.lizard.gesture))
				{
					Console.WriteLine(gestures.spidermanAttack.attack2);
				}
				else if (player1.gest == (gestures.paper.gesture))
				{
					Console.WriteLine(gestures.spidermanAttack.attack3);
				}
				else if (player1.gest == (gestures.wizard.gesture))
				{
					Console.WriteLine(gestures.spidermanAttack.attack4);
				}
				player2.score++;
			}
			else if ((player2.gest == (gestures.batman.gesture)) &&     // Player 2 chooses "Batman"
				(player1.gest == (gestures.spiderman.gesture) ||
				player1.gest == (gestures.scissors.gesture) ||
				player1.gest == (gestures.rock.gesture) ||
				player1.gest == (gestures.spock.gesture)))
			{
				if (player1.gest == (gestures.spiderman.gesture))
				{
					Console.WriteLine(gestures.batmanAttack.attack1);
				}
				else if (player1.gest == (gestures.scissors.gesture))
				{
					Console.WriteLine(gestures.batmanAttack.attack2);
				}
				else if (player1.gest == (gestures.rock.gesture))
				{
					Console.WriteLine(gestures.batmanAttack.attack3);
				}
				else if (player1.gest == (gestures.spock.gesture))
				{
					Console.WriteLine(gestures.batmanAttack.attack4);
				}
				player2.score++;
			}
			else if ((player2.gest == (gestures.wizard.gesture)) &&     // Player 2 chooses "Wizard"
				(player1.gest == (gestures.batman.gesture) ||
				player1.gest == (gestures.paper.gesture) ||
				player1.gest == (gestures.lizard.gesture) ||
				player1.gest == (gestures.glock.gesture)))
			{
				if (player1.gest == (gestures.batman.gesture))
				{
					Console.WriteLine(gestures.wizardAttack.attack1);
				}
				else if (player1.gest == (gestures.paper.gesture))
				{
					Console.WriteLine(gestures.wizardAttack.attack2);
				}
				else if (player1.gest == (gestures.lizard.gesture))
				{
					Console.WriteLine(gestures.wizardAttack.attack3);
				}
				else if (player1.gest == (gestures.glock.gesture))
				{
					Console.WriteLine(gestures.wizardAttack.attack4);
				}
				player2.score++;
			}
			else if ((player2.gest == (gestures.glock.gesture)) &&     // Player 2 chooses "Glock"
				(player1.gest == (gestures.rock.gesture) ||
				player1.gest == (gestures.batman.gesture) ||
				player1.gest == (gestures.spock.gesture) ||
				player1.gest == (gestures.scissors.gesture)))
			{
				if (player1.gest == (gestures.rock.gesture))
				{
					Console.WriteLine(gestures.glockAttack.attack1);
				}
				else if (player1.gest == (gestures.batman.gesture))
				{
					Console.WriteLine(gestures.glockAttack.attack2);
				}
				else if (player1.gest == (gestures.spock.gesture))
				{
					Console.WriteLine(gestures.glockAttack.attack3);
				}
				else if (player1.gest == (gestures.scissors.gesture))
				{
					Console.WriteLine(gestures.glockAttack.attack4);
				}
				player2.score++;
			}
		}

		// Display Score
		public void PrintScore()
		{
			Console.WriteLine("\n\nAs it stands...\n" +
				$"Player 1's Score: {player1.score}\n" +
				$"Player 2's Score: {player2.score}\n\n");
			Refresher(); 			// Screen Refresh
		}

		// Display Victor
		public void PrintVictor()
		{
			if(player1.score == winningScore)
			{
				Console.WriteLine($"\n\nPlayer 1 wins this time with a score of {player1.score}!");
				Refresher(); 			// Screen Refresh
			}
			else if (player2.score == winningScore)
			{
				Console.WriteLine($"\n\nPlayer 2 wins this time with a score of {player2.score}!");
				Refresher(); 			// Screen Refresh
			}
			else
			{
				return;
			}
		}
		// Game Type
		public void GameTypeSelect()
		{
			Console.WriteLine("Choose: \n1 for Human vs AI game\nor\n2 for Human vs Human game.");
			string userGT = Console.ReadLine();
			if (userGT == "1")
			{
				player2 = new Ai();       // Creates a Human vs AI game
				Console.WriteLine("An AI opponent approaches!");
			}
			else if (userGT == "2")
			{
				player2 = new Human();    // Creates a Human vs Human game
				Console.WriteLine("Another human approaches!");
			}
			else
			{
				GameTypeSelect();					// Recycles for user input validation
			}
		}
		// Play Again?
		public void Rematch()
		{
			Console.WriteLine("Would you enjoy a friendly rematch (Y/N)? ");
			string userChoice = Console.ReadLine();
			while (rematch == false)
			{
				if (userChoice == "y" || userChoice == "Y" || userChoice == "yes" || userChoice == "Yes")
				{
					Console.WriteLine("BEGINNING NEW MATCH! \n");
					player1 = new Human();
					player2.score = 0;
					GameRun();
					viewRules = true;
				}
				else if (userChoice == "n" || userChoice == "N" || userChoice == "no" || userChoice == "No")
				{
					Console.WriteLine("Thank you for spending your time with us! \n");
					Console.Clear();
					Console.WriteLine("G O O D B Y E");
					viewRules = true;
				}
				else
				{
					Console.WriteLine("Apologies, User. I do not speak gibberish. Please enter 'yes' or 'no': ");
					userChoice = Console.ReadLine();
				}
			}
		}
		// Screen Refresh
		public void Refresher()
		{
			Console.WriteLine("Press 'Enter' to continue.");
			Console.ReadLine();
			Console.Clear();
		}
	}
}
