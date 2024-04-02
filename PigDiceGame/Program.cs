namespace PigDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
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

                Game.startTheGame(player1Name, player2Name);
              
            }
            else if (numberOfPlayers == 3)
            {
                Console.Clear();

                Console.WriteLine("Enter the name of the player 1: ");
                player1Name = Console.ReadLine();

                Console.Clear();

                Console.WriteLine("Enter the name of the player 2: ");
                player2Name = Console.ReadLine();

                Console.Clear();

                Console.WriteLine("Enter the name of the player 3: ");
                player3Name = Console.ReadLine();

                Game.startTheGame(player1Name, player2Name, player3Name);
            }
            else if (numberOfPlayers == 4) 
            {
                Console.Clear();

                Console.WriteLine("Enter the name of the player 1: ");
                player1Name = Console.ReadLine();

                Console.Clear();

                Console.WriteLine("Enter the name of the player 2: ");
                player2Name = Console.ReadLine();

                Console.Clear();

                Console.WriteLine("Enter the name of the player 3: ");
                player3Name = Console.ReadLine();

                Console.Clear();

                Console.WriteLine("Enter the name of the player 4: ");
                player4Name = Console.ReadLine();

                Game.startTheGame(player1Name, player2Name, player3Name, player4Name);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Enter a valid number of players");
            }
        }   
    }
}