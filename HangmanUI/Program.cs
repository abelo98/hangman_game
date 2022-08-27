
using GameLogic.Library;
using GameLogic.Library.GameFlux;


IHangmanFlux game = Factory.CreateHangmanFlux();

game.GetOptions();
game.StartGame();
