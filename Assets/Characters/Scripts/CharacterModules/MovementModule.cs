using System.Collections;
using UnityEngine;

namespace Characters.Scripts
{
    public class MovementModule
    {
        private readonly float _movementSpeed;
        private readonly Transform _selfTransform;

        public MovementModule(float movementSpeed, Transform selfTransform)
        {
            _movementSpeed = movementSpeed;
            _selfTransform = selfTransform;
        }

        public IEnumerator Move(Vector3 to)
        {
            while (Vector3.Distance( _selfTransform.position, to) > 0.5f)
            {
                _selfTransform.position += (to - _selfTransform.position).normalized * _movementSpeed;
                yield return null;
            }
        }
    }
}