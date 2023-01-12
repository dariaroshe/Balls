using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace SelectLevel
{
    public class ButtonExitComponent : MonoBehaviour
    { 
        [SerializeField] private Button _buttonExit;

        private void Start()
        {
            _buttonExit.onClick.AddListener(OnButtonClick); 

        }
        
        private void OnDestroy()
        {
            _buttonExit.onClick.RemoveListener(OnButtonClick);
        }

        private void OnButtonClick()
        {
            SceneManager.LoadScene("Menu");
        }
    }
}