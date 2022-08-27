
namespace GameLogic.Library.Messages
{
    public class StandardMessages : IStandardMessages
    {
       

        public void WelcomeMsg() => Console.WriteLine("Welcome To the Hangman game!!!");
        public void VictoryGameMsg() => Console.WriteLine("You discovered the word... Hurra!!!");
        public void LifeSelectionMsg() => Console.WriteLine("How many chances will you give: ");
        public void LostGameMsg() => Console.WriteLine("Game Over!!! Try next time ;)");
        public void WordCreationMsg() => Console.WriteLine("Type the secret word");
        public void EmptyOrNullWordMsg() => Console.WriteLine("You Must Type a word");
        public void TypeLetterMsg() => Console.WriteLine("Type letter: ");
        public void WrongInputLetter(string? c) => Console.WriteLine($"{c} is not a letter");
        public void SelectedLettersMsg(List<string> letters)
        {
            Console.WriteLine($"You have used this letters: ");
            letters.ForEach(x => Console.Write($"{x} "));
        }
        public void AlreadySelectedLetterMsg(string? c) => Console.WriteLine($"{c} was already chosen");
        public void WrongInputNumber(string? n) => Console.WriteLine($"{n} is not a number");
    }
}
