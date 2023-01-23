using UnityEngine;
using UnityEngine.UI;

namespace SelectLevel
{
    public class BlockLevelButtonComponent : MonoBehaviour
    {
        [SerializeField] private Image _blockImage;

        private SelectLevelModel _selectLevelModel;
        private SelectLevelScene _selectLevelScene;
        private int _levelIndex;

        public void Initialize(SelectLevelModel selectLevelModel, SelectLevelScene selectLevelScene, int levelIndex)
        {
            _selectLevelModel = selectLevelModel;
            _selectLevelScene = selectLevelScene;
            _levelIndex = levelIndex;
            
            UnblockLevelButton();
        }

        private void UnblockLevelButton()
        {
            var currentLevel = PlayerPrefs.GetInt("CurrentLevel", 0);

            if (_levelIndex <= currentLevel)
            {
                _blockImage.gameObject.SetActive(false);
            }
        }
    }
}