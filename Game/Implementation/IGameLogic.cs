namespace GameLogic.Library.Implementation
{
    public interface IGameLogic
    {
        public List<string> SelectedLetters { get; }
        public bool[] DiscoveredLetters { get; }
        void Initialize(string word, int lifes);
        void Play(string letter);
        bool CheckLetterChosen(string letter);
        bool CheckLossCondition();
        bool CheckVictoryCondition();
        void Show();
    }
}