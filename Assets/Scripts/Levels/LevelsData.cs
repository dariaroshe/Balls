using System.Collections.Generic;
using UnityEngine;

namespace Levels
{
    [CreateAssetMenu(fileName = "LevelsData", menuName = "Data/LevelsData", order = 0)]
    public class LevelsData : ScriptableObject
    {
        public List<string> LevelNames;
    }
}