using System;
using Assets.Scripts;
using Assets.Scripts.GameObjects;
using JetBrains.Annotations;
using UnityEngine;

[Serializable]
public class Enemy : MonoBehaviour
{
    [SerializeField] private float MovementSpeed;
    [SerializeField] private Player _targetPlayer;
    [SerializeField] private GameConstants.GameObjectColor _color;

	// Use this for initialization
	[UsedImplicitly]
    void Start () {
    
	}
	
	// Update is called once per frame
    [UsedImplicitly]
	void Update ()
    {
        if (_targetPlayer == null)
        {
            return;
        }
        transform.position = Vector3.MoveTowards(transform.position, _targetPlayer.transform.position,
            Time.fixedDeltaTime*MovementSpeed);
    }

    [UsedImplicitly]
    public void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }

    public GameConstants.GameObjectColor GetColor()
    {
        return _color;
    }


}
