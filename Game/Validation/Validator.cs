using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Library.Validation
{
    public class Validator : IValidator
    {
        public bool ValidateWord(string? word)
        {
            //TODO: Validate word doesn't contain number or special char.
            return !string.IsNullOrEmpty(word);
        }
        public bool ValidateLetter(string? letter)
        {
            var r = !double.TryParse(letter, out _);
            return !string.IsNullOrEmpty(letter) && r;
        }

        public bool ValidateNumber(string? number)
        {
            return !string.IsNullOrEmpty(number) && int.TryParse(number, out _);
        }
    }
}
