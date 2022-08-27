using GameLogic.Library.GameFlux;
using GameLogic.Library.Implementation;
using GameLogic.Library.Messages;
using GameLogic.Library.Validation;

namespace GameLogic.Library
{
    public static class Factory
    {
        public static IGameLogic CreateGame() => new Game();

        public static IHangmanFlux CreateHangmanFlux()
        {
            return new HangmanFlux(CreateStandardMessages(), CreateGame(), CreateValidator());
        }
        public static IValidator CreateValidator() => new Validator();
        public static IStandardMessages CreateStandardMessages() => new StandardMessages();

    }
}
