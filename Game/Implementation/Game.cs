using GameLogic.Library.Messages;
using GameLogic.Library.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Library.Implementation
{
    public class Game : IGameLogic
    {
        int _lifes = 7;
        string _word = "";
        bool [] _discoveredLetters = new bool[0];
        List<string> _selectedLetters = new List<string>();

        public List<string> SelectedLetters { get => _selectedLetters; private set => _selectedLetters = value; }
        public bool[] DiscoveredLetters { get => _discoveredLetters; private set => _discoveredLetters = value; }

        public void Initialize(string word, int lifes)
        {
            DiscoveredLetters = new bool[word.Length];
            SelectedLetters = new List<string>();
            _lifes = lifes;
            _word = word;

        }
        public void Play(string letter)
        {
           
            for (int i = 0; i < _word.Length; i++)
            {
                if (_word[i].ToString() == letter)
                {
                    DiscoveredLetters[i] = true;
                }
            }
            _lifes += -1;
            SelectedLetters.Add(letter);
        }

        public void Show()
        {
            string output = "";

            for (int i = 0; i < DiscoveredLetters.Length; i++)
            {
                output += DiscoveredLetters[i] ? $"{_word[i]} " : "__ ";
            }

            Console.WriteLine(output);
        }

        public bool CheckLossCondition() => _lifes == 0;

        public bool CheckVictoryCondition() => DiscoveredLetters.All((x) => x == true);

        public bool CheckLetterChosen(string letter) => SelectedLetters.Contains(letter);
        
    }
}
