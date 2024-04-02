using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame
{
    internal class Game
    {
        public static void startTheGame(string player1Name, string player2Name)
        {
            Player player1Object = new Player(player1Name);
            Player player2Object = new Player(player2Name);

            Console.Clear();

            while (player1Object.Win != true || player2Object.Win != true)
            {
                Console.WriteLine(player1Name + ", type 'R' to start the game");
                string startGame = Console.ReadLine();

                if (startGame == "R")
                {
                    bool loseOrStop = false;
                    player1Turn(player1Object, startGame, loseOrStop);

                    loseOrStop = false;

                    Console.WriteLine(player2Name + ", type 'S' to start the game");
                    startGame = Console.ReadLine();

                    if (startGame == "S")
                    {
                        player2Turn(player2Object, startGame, loseOrStop);
                    }

                }
            }
        }

        public static void startTheGame(string player1Name, string player2Name, string player3Name)
        {
            Player player1Object = new Player(player1Name);
            Player player2Object = new Player(player2Name);
            Player player3Object = new Player(player3Name);

            Console.Clear();

            while (player1Object.Win != true || player2Object.Win != true)
            {
                Console.WriteLine(player1Name + ", type 'R' to start the game");
                string startGame = Console.ReadLine();

                if (startGame == "R")
                {
                    bool loseOrStop = false;
                    player1Turn(player1Object, startGame, loseOrStop);

                    Console.WriteLine(player2Name + ", type 'S' to start the game");
                    startGame = Console.ReadLine();

                    if (startGame == "S")
                    {
                        loseOrStop = false;
                        player2Turn(player2Object, startGame, loseOrStop);

                        Console.WriteLine(player3Name + ", type 'T' to start the game");
                        startGame = Console.ReadLine();

                        if (startGame == "T")
                        {
                            loseOrStop = false;
                            player3Turn(player3Object, startGame, loseOrStop);
                        }
                    }

                }
            }
        }

        public static void startTheGame(string player1Name, string player2Name, string player3Name, string player4Name)
        {
            Player player1Object = new Player(player1Name);
            Player player2Object = new Player(player2Name);
            Player player3Object = new Player(player3Name);
            Player player4Object = new Player(player4Name);

            Console.Clear();

            while (player1Object.Win != true || player2Object.Win != true)
            {
                Console.WriteLine(player1Name + ", type 'R' to start the game");
                string startGame = Console.ReadLine();

                if (startGame == "R")
                {
                    bool loseOrStop = false;
                    player1Turn(player1Object, startGame, loseOrStop);

                    loseOrStop = false;

                    Console.WriteLine(player2Name + ", type 'S' to start the game");
                    startGame = Console.ReadLine();

                    if (startGame == "S")
                    {
                        loseOrStop = false;
                        player2Turn(player2Object, startGame, loseOrStop);

                        Console.WriteLine(player3Name + ", type 'T' to start the game");
                        startGame = Console.ReadLine();

                        if (startGame == "T")
                        {
                            loseOrStop = false;
                            player3Turn(player3Object, startGame, loseOrStop);

                            Console.WriteLine(player4Name + ", type 'U' to start the game");
                            startGame = Console.ReadLine();

                            if (startGame == "U")
                            {
                                loseOrStop = false;
                                player4Turn(player4Object, startGame, loseOrStop);
                            }
                        }
                    }

                }
            }
        }

        public static void player1Turn(Player player1Object, string startGame, bool loseOrStop)
        {
            while (startGame == "R" && loseOrStop == false)
            {
                Console.Clear();

                int dice1 = Player.RollTheDice();
                Console.WriteLine(player1Object.Name + " rolled the dice!");
                Console.WriteLine("The dice fell on number " + dice1 + "\n");

                int dice2 = Player.RollTheDice();
                Console.WriteLine(player1Object.Name + " rolled the dice!");
                Console.WriteLine("The dice fell on number " + dice2 + "\n");

                player1Object.TurnScore += dice1 + dice2;

                Console.ReadLine();
                Console.Clear();

                if (dice1 != 1 && dice2 != 1)
                {
                    Console.WriteLine(player1Object.Name + " total points on the turn: " + player1Object.TurnScore);

                    Console.ReadLine();
                    Console.Clear();

                }

                bool showFinalStatementMessage = true;
                if (dice1 != 1 && dice2 != 1)
                {
                    showFinalStatementMessage = false;

                    Console.WriteLine("Type R to Roll the Dice Again | Type X to Stop");
                    startGame = Console.ReadLine();

                    if (startGame == "X")
                    {
                        setOverallScoreAndVerifyWin(player1Object);
                    }
                }
                else
                {
                    Console.WriteLine("The dice fell on number 1 and therefore the player " + player1Object.Name + " lost all your turn score!");
                    player1Object.TurnScore = 0;
                    Console.WriteLine("\nNow " + player1Object.Name + " turn score is: " + player1Object.TurnScore);
                    Console.ReadLine();

                    loseOrStop = true;
                }

                if (showFinalStatementMessage)
                {
                    setOverallScoreAndVerifyWin(player1Object);
                }
            }
        }

        public static void player2Turn(Player player2Object, string startGame, bool loseOrStop)
        {
            while (startGame == "S" && loseOrStop == false)
            {
                Console.Clear();

                int dice1 = Player.RollTheDice();
                Console.WriteLine(player2Object.Name + " rolled the dice!");
                Console.WriteLine("The dice fell on number " + dice1 + "\n");

                int dice2 = Player.RollTheDice();
                Console.WriteLine(player2Object.Name + " rolled the dice!");
                Console.WriteLine("The dice fell on number " + dice2 + "\n");

                player2Object.TurnScore += dice1 + dice2;

                Console.ReadLine();
                Console.Clear();

                if (dice1 != 1 && dice2 != 1)
                {
                    Console.WriteLine(player2Object.Name + " total points on the turn: " + player2Object.TurnScore);

                    Console.ReadLine();
                    Console.Clear();

                }

                bool showFinalStatementMessage = true;
                if (dice1 != 1 && dice2 != 1)
                {
                    showFinalStatementMessage = false;

                    Console.WriteLine("Type R to Roll the Dice Again | Type X to Stop");
                    startGame = Console.ReadLine();

                    if (startGame == "X")
                    {
                        setOverallScoreAndVerifyWin(player2Object);
                    }
                }
                else
                {
                    Console.WriteLine("The dice fell on number 1 and therefore the player " + player2Object.Name + " lost all your turn score!");
                    player2Object.TurnScore = 0;
                    Console.WriteLine("\nNow " + player2Object.Name + " turn score is: " + player2Object.TurnScore);
                    Console.ReadLine();

                    loseOrStop = true;
                }

                if (showFinalStatementMessage)
                {
                    setOverallScoreAndVerifyWin(player2Object);
                }
            }
        }

        public static void player3Turn(Player player3Object, string startGame, bool loseOrStop)
        {
            while (startGame == "T" && loseOrStop == false)
            {
                Console.Clear();

                int dice1 = Player.RollTheDice();
                Console.WriteLine(player3Object.Name + " rolled the dice!");
                Console.WriteLine("The dice fell on number " + dice1 + "\n");

                int dice2 = Player.RollTheDice();
                Console.WriteLine(player3Object.Name + " rolled the dice!");
                Console.WriteLine("The dice fell on number " + dice2 + "\n");

                player3Object.TurnScore += dice1 + dice2;

                Console.ReadLine();
                Console.Clear();

                if (dice1 != 1 && dice2 != 1)
                {
                    Console.WriteLine(player3Object.Name + " total points on the turn: " + player3Object.TurnScore);

                    Console.ReadLine();
                    Console.Clear();

                }

                bool showFinalStatementMessage = true;
                if (dice1 != 1 && dice2 != 1)
                {
                    showFinalStatementMessage = false;

                    Console.WriteLine("Type R to Roll the Dice Again | Type X to Stop");
                    startGame = Console.ReadLine();

                    if (startGame == "X")
                    {
                        setOverallScoreAndVerifyWin(player3Object);
                    }
                }
                else
                {
                    Console.WriteLine("The dice fell on number 1 and therefore the player " + player3Object.Name + " lost all your turn score!");
                    player3Object.TurnScore = 0;
                    Console.WriteLine("\nNow " + player3Object.Name + " turn score is: " + player3Object.TurnScore);
                    Console.ReadLine();

                    loseOrStop = true;
                }

                if (showFinalStatementMessage)
                {
                    setOverallScoreAndVerifyWin(player3Object);
                }
            }
        }

        public static void player4Turn(Player player4Object, string startGame, bool loseOrStop)
        {
            while (startGame == "U" && loseOrStop == false)
            {
                Console.Clear();

                int dice1 = Player.RollTheDice();
                Console.WriteLine(player4Object.Name + " rolled the dice!");
                Console.WriteLine("The dice fell on number " + dice1 + "\n");

                int dice2 = Player.RollTheDice();
                Console.WriteLine(player4Object.Name + " rolled the dice!");
                Console.WriteLine("The dice fell on number " + dice2 + "\n");

                player4Object.TurnScore += dice1 + dice2;

                Console.ReadLine();
                Console.Clear();

                if (dice1 != 1 && dice2 != 1)
                {
                    Console.WriteLine(player4Object.Name + " total points on the turn: " + player4Object.TurnScore);

                    Console.ReadLine();
                    Console.Clear();

                }

                bool showFinalStatementMessage = true;
                if (dice1 != 1 && dice2 != 1)
                {
                    showFinalStatementMessage = false;

                    Console.WriteLine("Type R to Roll the Dice Again | Type X to Stop");
                    startGame = Console.ReadLine();

                    if (startGame == "X")
                    {
                        setOverallScoreAndVerifyWin(player4Object);
                    }
                }
                else
                {
                    Console.WriteLine("The dice fell on number 1 and therefore the player " + player4Object.Name + " lost all your turn score!");
                    player4Object.TurnScore = 0;
                    Console.WriteLine("\nNow " + player4Object.Name + " turn score is: " + player4Object.TurnScore);
                    Console.ReadLine();

                    loseOrStop = true;
                }

                if (showFinalStatementMessage)
                {
                    setOverallScoreAndVerifyWin(player4Object);
                }
            }
        }

        public static void setOverallScoreAndVerifyWin(Player playerObject)
        {
            playerObject.OverallScore += playerObject.TurnScore;
            if (playerObject.OverallScore >= 100)
            {
                playerObject.Win = true;

                Console.Clear();
                Console.WriteLine("Now " + playerObject.Name + " overall score is: " + playerObject.OverallScore);
                Console.WriteLine("The player " + playerObject.Name + " reached 100 points and won the game!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Now " + playerObject.Name + " overall score is: " + playerObject.OverallScore);
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
