using System;
using UnityEngine;

namespace SelectLevel
{
    public class SelectLevelStarter : MonoBehaviour
    {
        public SelectLevelScene SelectLevelScene;

        private void Start()
        {
            var selectLevelModel = new SelectLevelModel();
            
            SelectLevelScene.SpawnLevelButtonsComponent.Initialize(selectLevelModel, SelectLevelScene);
        }
    }
}