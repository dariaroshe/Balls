using System.Collections.Generic;
using UnityEngine;

namespace Levels
{
    [CreateAssetMenu(fileName = "LevelsData", menuName = "Data/LevelsData", order = 0)]
    public class LevelsData : ScriptableObject
    {
        public List<string> LevelNames;

        public int GetNextLevel(int currentLevel)
        {
            if (currentLevel >= LevelNames.Count)
            {
                return LevelNames.Count - 1;
            }

            return currentLevel;
        }
    }
}