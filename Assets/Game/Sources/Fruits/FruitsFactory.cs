using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Game.Sources.Fruits
{
    public class FruitsFactory : MonoBehaviour
    {
        public Fruit[] _prefabs; 
        public Vector2 spawnRange = new Vector2(5f, 5f); 

        private float _timer = 0f;

        private void Update()
        {
            _timer += Time.deltaTime;
            
            if(Random.Range(.5f , .7f) < _timer)
            {
                SpawnObject();
                _timer = 0f;
            }
        }

        void SpawnObject()
        {
            float spawnX = Random.Range(-spawnRange.x, spawnRange.x);

            Instantiate(_prefabs[Random.Range(0, _prefabs.Length)], new Vector3(spawnX, transform.position.y, 0f),
                Quaternion.identity);
        }
        
        void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireCube(transform.position, new Vector3(spawnRange.x * 2, spawnRange.y * 2, 0f));
        }
    }
}