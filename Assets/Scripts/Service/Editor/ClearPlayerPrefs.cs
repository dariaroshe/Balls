using UnityEditor;
using UnityEngine;

namespace Service.Editor
{
    public class ClearPlayerPrefs
    {
        [MenuItem("Window/Clear Player Prefs")]
        public static void DoClearPlayerPrefs()
        {
            PlayerPrefs.DeleteAll();
        }
    }
}