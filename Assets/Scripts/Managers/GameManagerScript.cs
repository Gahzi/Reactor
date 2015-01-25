
using System;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.GameObjects;
using JetBrains.Annotations;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Assets.Scripts.Managers
{
    public class GameManagerScript : Singleton<GameManagerScript>
    {

        [SerializeField] private float _defaultTimeToSpawnEnemy;
        [SerializeField] private float _timeToSpawnEnemy;

        [SerializeField] private int[] _randomTypeWeights = { 0,0};
        [SerializeField] private int[] _randomColorWeights = { 0,0,0};

        // Use this for initialization
        [UsedImplicitly]
        void Start () 
        {

        }
	
        // Fixed Update is called once per frame
        [UsedImplicitly]
        void FixedUpdate ()
        {
            CheckSpawnTimer();
        }

        private void CheckSpawnTimer()
        {
            if (_timeToSpawnEnemy - Time.fixedDeltaTime <= 0)
            {
                SpawnNewRandomItem();
                _timeToSpawnEnemy = _defaultTimeToSpawnEnemy;
            }
            else
            {
                _timeToSpawnEnemy -= Time.fixedDeltaTime;
            }
        }

        private void SpawnNewRandomItem()
        {
            ObjectConstants.Type[] types = (ObjectConstants.Type[]) Enum.GetValues(typeof (ObjectConstants.Type));
            int totalTypeWeight = _randomTypeWeights.Sum();
            int currentType = 0;
            List<ObjectConstants.Type> fullTypes = new List<ObjectConstants.Type>(totalTypeWeight);

            while (currentType < types.Length)
            {
                for (int i = 0; i < _randomTypeWeights[currentType]; i++)
                {
                    fullTypes.Add(types[currentType]);
                }
                currentType++;
            }

            GameConstants.GameObjectColor[] colors = (GameConstants.GameObjectColor[])Enum.GetValues(typeof(GameConstants.GameObjectColor));
            int totalColorsWeight = _randomColorWeights.Sum();
            int currentColor = 0;
            List<GameConstants.GameObjectColor> fullColors = new List<GameConstants.GameObjectColor>(totalColorsWeight);

            while (currentColor < colors.Length)
            {
                for (int i = 0; i < _randomColorWeights[currentColor]; i++)
                {
                    fullColors.Add(colors[currentColor]);
                }
                currentColor++;
            }

            int randomTypeIndex = Random.Range(0, fullTypes.Count);
            int randomColorsIndex = Random.Range(0, fullColors.Count);
            ObjectConstants.Type newType = fullTypes[randomTypeIndex];
            GameConstants.GameObjectColor newColor = fullColors[randomColorsIndex];
            SpawnNewItem(newType, newColor);
        }

        private void SpawnNewItem(ObjectConstants.Type newType, GameConstants.GameObjectColor newColor)
        {
            GameObject newItem = (GameObject) Instantiate(Resources.Load(ObjectConstants.PrefabNames[newType]));
            SpriteRenderer newRenderer = newItem.GetComponent<SpriteRenderer>();
            newRenderer.color = GameConstants.ColorCodes[newColor];

            if (newItem.GetComponent<Enemy>())
            {
                newItem.GetComponent<Enemy>().SetColor(newColor);
            }

            if (newItem.GetComponent<Food>())
            {
                newItem.GetComponent<Food>().SetColor(newColor);
            }
        }
    }
}
