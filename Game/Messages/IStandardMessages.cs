namespace GameLogic.Library.Messages
{
    public interface IStandardMessages
    {
        void TypeLetterMsg();
        void EmptyOrNullWordMsg();
        void VictoryGameMsg();
        void LifeSelectionMsg();
        void LostGameMsg();
        void WelcomeMsg();
        void WordCreationMsg();
        void WrongInputLetter(string? c);
        void WrongInputNumber(string? n);
        void AlreadySelectedLetterMsg(string? c);
        void SelectedLettersMsg(List<string> letters);

    }
}