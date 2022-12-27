using System;
using Game;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Balls
{
    public class RandomSpawnerColorBallsComponent : MonoBehaviour
    {
        [SerializeField] private GameObject[] _colorBalls;
        [SerializeField] private Transform _position;

        public int RandomColorBall;

        private void Start()
        {
            SpawnColorBall();
        }

        private void SpawnColorBall()
        {
            RandomColorBall = Random.Range(0, _colorBalls.Length);

            Instantiate(_colorBalls[RandomColorBall], _position.transform.position, Quaternion.identity);
        }
    }
}