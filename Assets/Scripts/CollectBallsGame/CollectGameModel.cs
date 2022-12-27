using Service;

namespace CollectBallsGame
{
    public class CollectGameModel
    {
        public Field<int> Score = new Field<int>();
        public Field<int> FailedBalls = new Field<int>();
        public Field<GameState> GameState = new Field<GameState>();
    }
}