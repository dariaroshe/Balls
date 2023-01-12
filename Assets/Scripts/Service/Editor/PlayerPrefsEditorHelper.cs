using UnityEditor;
using UnityEngine;

namespace Service.Editor
{
    public class PlayerPrefsEditorHelper
    {
        [MenuItem("PlayerPrefs/Clear Player Prefs")]
        public static void DoClearPlayerPrefs()
        {
            PlayerPrefs.DeleteAll();
        }
    }
}