using System;
using JetBrains.Annotations;
using UnityEngine;

namespace Assets.Scripts.GameObjects
{

[Serializable]
public class Player : MonoBehaviour
    {
        [SerializeField] private int Health;
        [SerializeField] private GameConstants.GameObjectColor _color;

        // Use this for initialization
        [UsedImplicitly]
        private void Start()
        {
            if (Health == 0)
            {
                Health = 100;
            }

        }

        // Update is called once per frame
        [UsedImplicitly]
        private void Update()
        {
            CheckHealth();
        }

        private void CheckHealth()
        {
            if (Health <= 0)
            {
                Destroy(gameObject);
            }
        }

        [UsedImplicitly]
        public void IsTouched()
        {
            Debug.Log("Touched!");
        }

        [UsedImplicitly]
        public void OnTriggerEnter2D(Collider2D other)
        {
            Enemy collidedEnemy = other.gameObject.GetComponent<Enemy>();

            if (collidedEnemy)
            {
                if (collidedEnemy.GetColor() == _color)
                {
                    //incrementScore
                }
                else
                {
                    Health -= 10;
                }
                
            }
            
        }
    }
}
