using System.Collections;
using UnityEngine;

namespace Characters.Scripts
{
    public class Teacher : Worker
    {
        private readonly string _school = "School";

        protected override void MorningThoughts()
        {
            Debug.Log("I don't want to teach today...");
        }

        protected override void EatBreakfast()
        {
            Debug.Log("Eating children's tears for breakfast.");
        }

        protected override void GetDressed()
        {
        }

        protected override IEnumerator GoToWork()
        {
            var school = GameObject.Find(_school).transform.position;
            var speed = 0.05f;
            while (Vector3.Distance(school, transform.position) > 0.5f)
            {
                transform.position += (school - transform.position).normalized * speed;
                yield return null;
            }
        }

        protected override void Work()
        {
            Debug.Log("I hate my job.");
            Debug.Log("Teaching template methods to children.");
        }
    }
}
