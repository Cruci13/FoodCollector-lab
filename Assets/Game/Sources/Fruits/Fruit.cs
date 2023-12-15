using System;
using UnityEngine;

namespace Game.Sources.Fruits
{
    public abstract class Fruit : MonoBehaviour
    {
        private void OnEnable()
        {
            Invoke(nameof(DestroyFruit) , 1.5f);
        }
        
        private void DestroyFruit()
        {
            Destroy(gameObject);
        }
    }
}