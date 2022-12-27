using System.Collections;
using UnityEngine;

namespace Stick
{
    public class RemoveStickComponent : MonoBehaviour
    {
        private bool _isRemoving;
        [SerializeField] private float _speed = 10f;

        private void OnMouseDown()
        {
            if (!_isRemoving)
            {
                StartCoroutine(RemoveStick());
                _isRemoving = true;
            }
        }

        private IEnumerator RemoveStick()
        {
            var time = 0f;

            var random = Random.Range(0, 2);
            _speed *= random == 0 ? 1f : -1f;

            while (time < 0.5f)
            {
                transform.localPosition += new Vector3(_speed * Time.deltaTime, 0f, 0f);
                
                yield return null;

                time += Time.deltaTime;
            }

            Destroy(gameObject);
        }
    }
}