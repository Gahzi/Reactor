using System;
using JetBrains.Annotations;
using UnityEngine;

namespace Assets.Scripts.GameObjects
{

[Serializable]
public class Player : MonoBehaviour
    {
        [SerializeField] private int _health;
        [SerializeField] private GameConstants.GameObjectColor _color;

        // Use this for initialization
        [UsedImplicitly]
        private void Start()
        {
            if (_health == 0)
            {
                _health = 100;
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
            if (_health <= 0)
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
            Food collidedFood = other.gameObject.GetComponent<Food>();


            if (collidedEnemy)
            {
                if (collidedEnemy.GetColor() == _color)
                {
                    //incrementScore
                }
                else
                {
//					AudioSource.Play("Audio/sfx/rr_audio_hit_01");
                    _health -= collidedEnemy.GetDamage();
                }
            }
            else if (collidedFood)
            {
                SpriteRenderer renderer = GetComponent<SpriteRenderer>();
                renderer.color = GameConstants.ColorCodes[collidedFood.GetColor()];

                _health += collidedFood.GetHealthGained();
            }

            
        }
    }
}
