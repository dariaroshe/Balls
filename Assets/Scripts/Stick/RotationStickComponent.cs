using System;
using System.Collections;
using UnityEngine;

namespace Stick
{
    public class RotationStickComponent : MonoBehaviour
    {
        private bool _isMouseDown;
        
        [SerializeField] private float _speed = 15f;
        
        private void OnMouseDown()
        {
            _isMouseDown = true;
        }

        private void Update()
        {
            if (_isMouseDown)
            {
                transform.Rotate(0f, 0f, _speed * Time.deltaTime);
            }
        }

        private void OnMouseUp()
        {
            _isMouseDown = false;
        }
    }
}