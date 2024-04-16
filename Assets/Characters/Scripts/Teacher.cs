using System.Collections;
using UnityEngine;

namespace Characters.Scripts
{
    public class Teacher : Worker
    {
        private MovementModule _movementModule;
        private readonly float _moveSpeed = 0.1f;

        private void Awake()
        {
            _movementModule = new MovementModule(_moveSpeed, transform);
        }
        
        protected override void GetDressed()
        {
            foreach (var mesh in _meshRenderers)
            {
                mesh.materials[0] = _outfitData.TeacherOutfit;
            }
        }

        protected override IEnumerator GoToWork()
        {
            var workLocation = GameObject.Find("School").transform;
            yield return _movementModule.Move(workLocation.position);
        }

        protected override void Work()
        {
            Debug.Log("teaching difference between inheritance and composition");
        }
    }
}
