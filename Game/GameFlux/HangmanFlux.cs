using GameLogic.Library.Implementation;
using GameLogic.Library.Messages;
using GameLogic.Library.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Library.GameFlux
{
    public class HangmanFlux : IHangmanFlux
    {
        IStandardMessages _standardMessages;
        IGameLogic _gameLogic;
        IValidator _validator;

        public HangmanFlux(IStandardMessages standardMessages, IGameLogic gameLogic,
            IValidator validator)
        {
            _gameLogic = gameLogic;
            _standardMessages = standardMessages;
            _validator = validator;
        }

        public void GetOptions()
        {
            while (true)
            {
                _standardMessages.WelcomeMsg();
                _standardMessages.LifeSelectionMsg();
                string? lifes = Console.ReadLine();

                if (_validator.ValidateNumber(lifes) == false)
                {
                    _standardMessages.WrongInputNumber(lifes);
                    continue;
                }

                _standardMessages.WordCreationMsg();
                string? word = Console.ReadLine();

                if (_validator.ValidateWord(word) == false)
                {
                    _standardMessages.EmptyOrNullWordMsg();
                    continue;
                }

                _gameLogic = Factory.CreateGame();
                _gameLogic.Initialize(word, int.Parse(lifes));

                break;
            }
        }

        public void StartGame()
        {
            while (!_gameLogic.CheckLossCondition())
            {
                _standardMessages.SelectedLettersMsg(_gameLogic.SelectedLetters);
                Console.WriteLine();
                _gameLogic.Show();
                _standardMessages.TypeLetterMsg();

                string? letter = Console.ReadLine();
                if (_validator.ValidateLetter(letter) == false)
                {
                    _standardMessages.WrongInputLetter(letter);
                    continue;
                }
               
                _gameLogic.Play(letter);
                Console.WriteLine();

                _gameLogic.Show();
                Console.WriteLine();

                if (_gameLogic.CheckVictoryCondition())
                {
                    _standardMessages.VictoryGameMsg();
                    break;
                }

            }

            _standardMessages.LostGameMsg();
        }
    }
}
