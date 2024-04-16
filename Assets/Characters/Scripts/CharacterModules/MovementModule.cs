using System.Collections;
using UnityEngine;

namespace Characters.Scripts
{
    public class MovementModule
    {
        private readonly float _movementSpeed;
        private readonly Transform _selfTransform;
        private const float MovementTolerance = 0.5f;

        public MovementModule(float movementSpeed, Transform selfTransform)
        {
            _movementSpeed = movementSpeed;
            _selfTransform = selfTransform;
        }

        public IEnumerator Move(Vector3 to)
        {
            while (Vector3.Distance( _selfTransform.position, to) > MovementTolerance)
            {
                var position = _selfTransform.position;
                position += (to - position).normalized * _movementSpeed;
                _selfTransform.position = position;
                yield return null;
            }
        }
    }
}