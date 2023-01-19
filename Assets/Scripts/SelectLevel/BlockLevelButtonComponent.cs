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
            var levelCompleted = PlayerPrefs.GetInt("CurrentLevel", -1);

            if (_levelIndex <= levelCompleted + 1)
            {
                _blockImage.gameObject.SetActive(false);
            }
        }
    }
}