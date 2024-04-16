using System.Collections;
using UnityEngine;

namespace Characters.Scripts
{
    public class ShopAssistant : Worker
    {
        protected override void MorningThoughts()
        {
            base.MorningThoughts();
            Debug.Log("Today Im going to sell more than Kathy");
        }

        protected override void EatBreakfast()
        {
            Debug.Log("Not Having a big breakfast today, I think Im too fat");
        }

        protected override void GetDressed()
        {
            foreach (var mesh in _meshRenderers)
            {
                mesh.materials[0] = _outfitData.ShopAssistantOutfit;
            }
            Debug.Log("I look great!");
        }

        protected override IEnumerator GoToWork()
        {
            var storePosition = GameObject.Find("Store").transform.position;
            var speed = 0.05f;
            while (Vector3.Distance(storePosition, transform.position) > 0.5f)
            {
                transform.position += (storePosition - transform.position).normalized * speed;
                yield return null;
            }
        }

        protected override void Work()
        {
           Debug.Log("Lets sell some stufff!!!");
        }
    }
}
