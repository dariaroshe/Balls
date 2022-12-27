using UnityEngine;

namespace Stick
{
    public class AutoMovingStickComponent : MonoBehaviour
    {
        [SerializeField] private int _speed;
        
        [SerializeField] private float _minY = -1.5f;
        [SerializeField] private float _maxY = 1.5f;

        private bool _movingRight = true;

        private void Update()
        {
            MoveStick();
        }

        private void MoveStick()
        {
            if (transform.position.y > _maxY)
            {
                _movingRight = false;
            }
            else if (transform.position.y < _minY)
            {
                _movingRight = true;
            }

            if (_movingRight)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + _speed * Time.deltaTime);
            }
            else
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - _speed * Time.deltaTime);
            }
        }
    }
}