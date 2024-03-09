using System.Collections;
using UnityEngine;

namespace Characters.Scripts
{
    public class Firefighter : Worker
    {
        protected override void MorningThoughts()
        {
            Debug.Log("I hope there are no incidents today.");
        }

        protected override void EatBreakfast()
        {
            Debug.Log("Having a big breakfast. I'm probably going to need the energy.");
        }

        protected override void GetDressed()
        {
            foreach (var mesh in _meshRenderers)
            {
                mesh.materials[0] = _outfitData.FirefighterOutfit;
            }
        }

        protected override IEnumerator GoToWork()
        {
            var workLocation = GameObject.Find("FireStation").transform;
            var runningSpeed = 0.1f;
            
            while (Vector3.Distance(workLocation.position, transform.position) > 0.5f)
            {
                transform.position += (workLocation.position - transform.position).normalized * runningSpeed;
                yield return null;
            }
        }

        protected override void Work()
        {
            Debug.Log("Training hard while waiting for an emergency call.");
        }
    }
}
