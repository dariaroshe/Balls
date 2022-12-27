using System;
using UnityEngine;

namespace Basket
{
    public class AutoMovingBasketComponent : MonoBehaviour
    {
        //[SerializeField] private Vector2 _direction;
        [SerializeField] private int _speed;
        
        [SerializeField] private float _minX = -1.5f;
        [SerializeField] private float _maxX = 1.5f;

        private bool _movingRight = true;

        private void Update()
        {
            MoveBasket();
        }

        private void MoveBasket()
        {
            if (transform.position.x > _maxX)
            {
                _movingRight = false;
            }
            else if (transform.position.x < _minX)
            {
                _movingRight = true;
            }

            if (_movingRight)
            {
                transform.position = new Vector2(transform.position.x + _speed * Time.deltaTime, transform.position.y);
            }
            else
            {
                transform.position = new Vector2(transform.position.x - _speed * Time.deltaTime, transform.position.y);
            }
        }
    }
}