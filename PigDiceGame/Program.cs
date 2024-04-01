namespace PigDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player1Object;
            Player player2Object;
            Player player3Object;
            Player player4Object;

            Console.WriteLine("Pig Dice Game!\n");

            Console.WriteLine("Enter the number of players (Min 2 - Max 4): ");
            int numberOfPlayers = int.Parse(Console.ReadLine());

            string player1Name, player2Name, player3Name, player4Name;

            if (numberOfPlayers == 2)
            {
                Console.Clear();

                Console.WriteLine("Enter the name of the player 1: ");
                player1Name = Console.ReadLine();

                Console.Clear();

                Console.WriteLine("Enter the name of the player 2: ");
                player2Name = Console.ReadLine();

                player1Object = new Player(player1Name);
                player2Object = new Player(player2Name);

                Console.Clear();


                while (player1Object.Win != true || player2Object.Win != true)
                {
                    Console.WriteLine(player1Name + ", type 'R' to start the game");
                    string startGame = Console.ReadLine();

                    if (startGame == "R")
                    {
                        bool loseOrStop = false;
                        while (startGame == "R" && loseOrStop == false)
                        {
                            Console.Clear();

                            int dice1 = Player.RollTheDice();
                            Console.WriteLine(player1Name + " rolled the dice!");
                            Console.WriteLine("The dice fell on number " + dice1 + "\n");

                            int dice2 = Player.RollTheDice();
                            Console.WriteLine(player1Name + " rolled the dice!");
                            Console.WriteLine("The dice fell on number " + dice2 + "\n");

                            player1Object.TurnScore += dice1 + dice2;

                            Console.ReadLine();
                            Console.Clear();

                            if (dice1 != 1 && dice2 != 1)
                            {
                                Console.WriteLine(player1Name + " total points on the turn: " + player1Object.TurnScore);

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
                                    player1Object.OverallScore += player1Object.TurnScore;
                                    if (player1Object.OverallScore >= 100)
                                    {
                                        player1Object.Win = true;

                                        Console.Clear();
                                        Console.WriteLine("You chosen to Stop\n");
                                        Console.WriteLine("Now " + player1Name + " overall score is: " + player1Object.OverallScore);
                                        Console.WriteLine("The player " + player1Name + " reached 100 points and won the game!");
                                        Console.ReadLine();
                                        return;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Now " + player1Name + " overall score is: " + player1Object.OverallScore);
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("The dice fell on number 1 and therefore the player " + player1Name + " lost all your turn score!");
                                player1Object.TurnScore = 0;
                                Console.WriteLine("\nNow " + player1Name + " turn score is: " + player1Object.TurnScore);

                                loseOrStop = true;
                            }

                            if (showFinalStatementMessage)
                            {
                                player1Object.OverallScore += player1Object.TurnScore;
                                if (player1Object.OverallScore >= 100)
                                {
                                    player1Object.Win = true;

                                    Console.WriteLine("Now " + player1Name + " overall score is: " + player1Object.OverallScore);
                                    Console.WriteLine("The player " + player1Name + " reached 100 points and won the game!");
                                    Console.ReadLine();
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("Now " + player1Name + " overall score is: " + player1Object.OverallScore);
                                    Console.ReadLine();
                                }
                            }
                        }

                        loseOrStop = false;

                        Console.WriteLine(player2Name + ", type 'S' to start the game");
                        startGame = Console.ReadLine();

                        if (startGame == "S")
                        {
                            while (startGame == "S" && loseOrStop == false)
                            {
                                Console.Clear();

                                int dice1 = Player.RollTheDice();
                                Console.WriteLine(player2Name + " rolled the dice!");
                                Console.WriteLine("The dice fell on number " + dice1 + "\n");

                                int dice2 = Player.RollTheDice();
                                Console.WriteLine(player2Name + " rolled the dice!");
                                Console.WriteLine("The dice fell on number " + dice2 + "\n");

                                player2Object.TurnScore += dice1 + dice2;

                                Console.ReadLine();
                                Console.Clear();

                                if (dice1 != 1 && dice2 != 1)
                                {
                                    Console.WriteLine(player2Name + " total points on the turn: " + player2Object.TurnScore);

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
                                        player2Object.OverallScore += player2Object.TurnScore;
                                        if (player2Object.OverallScore >= 100)
                                        {
                                            player2Object.Win = true;

                                            Console.Clear();
                                            Console.WriteLine("You chosen to Stop\n");
                                            Console.WriteLine("Now " + player2Name + " overall score is: " + player2Object.OverallScore);
                                            Console.WriteLine("The player " + player2Name + " reached 100 points and won the game!");
                                            Console.ReadLine();
                                            return;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Now " + player2Name + " overall score is: " + player2Object.OverallScore);
                                            Console.ReadLine();
                                            Console.Clear();
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("The dice fell on number 1 and therefore the player " + player2Name + " lost all your turn score!");
                                    player2Object.TurnScore = 0;
                                    Console.WriteLine("\nNow " + player2Name + " turn score is: " + player2Object.TurnScore);

                                    loseOrStop = true;
                                }

                                if (showFinalStatementMessage)
                                {
                                    player2Object.OverallScore += player2Object.TurnScore;
                                    if (player2Object.OverallScore >= 100)
                                    {
                                        player2Object.Win = true;

                                        Console.WriteLine("Now " + player2Name + " overall score is: " + player2Object.OverallScore);
                                        Console.WriteLine("The player " + player2Name + " reached 100 points and won the game!");
                                        Console.ReadLine();
                                        return;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Now " + player2Name + " overall score is: " + player2Object.OverallScore);
                                        Console.ReadLine();
                                    }
                                }
                            }
                        }

                    }
                }
                

            }
            else if (numberOfPlayers == 3)
            {
                
            }
            else if (numberOfPlayers == 4) 
            {

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Enter a valid number of players");
            }

           

        }

        
    }
}