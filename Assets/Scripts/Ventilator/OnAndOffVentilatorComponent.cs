using System;
using UnityEngine;

namespace Ventilator
{
    public class OnAndOffVentilatorComponent : MonoBehaviour
    {
        [SerializeField] private AreaEffector2D _areaEffector2D;
        [SerializeField] private ParticleSystem _particleSystem;

        private bool _isActive = false;
        
        private void OnMouseDown()
        {
            if (_isActive)
            {
               _particleSystem.Play();
               _areaEffector2D.enabled = true;
               _isActive = false;
            }
            else
            {
                _particleSystem.Stop();
                _areaEffector2D.enabled = false;
                _isActive = true;
            }
        }

        private void OnMouseEnter()
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.gray;
        }
        
        private void OnMouseExit()
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}