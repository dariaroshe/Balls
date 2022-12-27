using Service;
using UnityEngine;

namespace Game
{
    public class GameModel 
    {
        public Field<int> Score = new Field<int>();
        public Field<int> FailedBalls = new Field<int>();
    }
}