using System;
using CollectBallsGame;
using UnityEngine;

namespace Basket
{
    public class MovingBasketComponent : CollectGameComponent
    {
        [SerializeField] private float _minX = -1.5f;
        [SerializeField] private float _maxX = 1.5f;
        
        private CollectGameModel _gameModel;
        private CollectGameScene _gameScene;

        public override void Initialize(CollectGameModel gameModel, CollectGameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }
        
        private void OnMouseDrag()
        {
            if (_gameModel.GameState.Value == GameState.Playing)
            {
                var mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                var x = Mathf.Clamp(mouseWorldPosition.x, _minX, _maxX);
                transform.position = new Vector3(x, transform.position.y, transform.position.z);
            }
        }
    }
}