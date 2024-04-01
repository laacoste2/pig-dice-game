using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame
{
    internal class Player
    {
        private string _name;
        private int _overallScore;
        private int _turnScore;
        private bool _win = false;

        public string Name { get => _name; set => _name = value; }
        public int OverallScore { get => _overallScore; set => _overallScore = value; }
        public int TurnScore { get => _turnScore; set => _turnScore = value; }
        public bool Win { get => _win; set => _win = value; }

        public Player(string name)
        {
            this._name = name;
        }

        public static int RollTheDice()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);

            return dice;
        }

    }
}
