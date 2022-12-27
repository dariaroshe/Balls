using System;
using UnityEngine;

namespace Trampoline
{
    public class TrampolineComponent : MonoBehaviour
    {
        [SerializeField] private float _forceJump;

        private void OnCollisionEnter2D(Collision2D other)
        {
            other.rigidbody.velocity = Vector2.up * _forceJump;
        }
    }
}