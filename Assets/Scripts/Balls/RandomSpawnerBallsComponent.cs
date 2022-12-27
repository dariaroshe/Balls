using System.Collections;
using System.Collections.Generic;
using CollectBallsGame;
using UnityEngine;

namespace Balls
{
    public class RandomSpawnerBallsComponent : CollectGameComponent
    {
        [SerializeField] private RigidbodyBallsComponent[] _spawnBalls;
        [SerializeField] private List<Transform> _spawnPoint;
        
        private CollectGameModel _gameModel;
        private CollectGameScene _gameScene;

        public override void Initialize(CollectGameModel gameModel, CollectGameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }
        
        private void Start()
        {
            StartCoroutine(Spawn());
        }

        private IEnumerator Spawn()
        {
            while (true)
            {
                var randomIndexBalls = Random.Range(0, _spawnBalls.Length);
                var randomIndexPoint = Random.Range(0, _spawnPoint.Count);
                
                if (_gameModel.GameState.Value == GameState.Playing)
                {
                    var ball = Instantiate(_spawnBalls[randomIndexBalls], _spawnPoint[randomIndexPoint].transform.position,
                        Quaternion.identity);
                    
                    ball.Initialize(_gameModel, _gameScene);
                }

                yield return new WaitForSeconds(1);
            }
        }
    }
}