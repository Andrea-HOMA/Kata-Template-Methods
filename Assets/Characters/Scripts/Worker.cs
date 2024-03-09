using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Characters.Scripts
{
    public abstract class Worker : MonoBehaviour
    {
        [SerializeField] protected List<SkinnedMeshRenderer> _meshRenderers;
        protected OutfitData _outfitData;
       
        void Start()
        {
            Initialize();
            StartCoroutine(DailyRoutine());
        }

        private void Initialize()
        {
            _outfitData = (OutfitData)Resources.Load("OutfitData");
        }

        private IEnumerator DailyRoutine() // Template method
        {
            GetUp();
            MorningThoughts();
            EatBreakfast();
            GetDressed();
            yield return GoToWork();
            Work();
        }

        private void GetUp() // Specific behaviour. Everyone does it. Can't be overriden.
        {
            Debug.Log("Good morning!");
        }
        
        protected virtual void MorningThoughts() // Default behaviour. Everyone does it by default. Can be overriden.
        {
            Debug.Log("Let's start the day.");
        }
        
        protected virtual void EatBreakfast() // No default behaviour. Will be skipped if not overriden.
        {
            
        }

        protected abstract void GetDressed(); // No default behaviour. Children are forced to override it.
        protected abstract IEnumerator GoToWork();
        protected abstract void Work();
    }
}
