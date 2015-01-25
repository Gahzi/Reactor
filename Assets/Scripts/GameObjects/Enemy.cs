using System;
using Assets.Scripts;
using Assets.Scripts.GameObjects;
using JetBrains.Annotations;
using UnityEngine;

[Serializable]
public class Enemy : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private int _damage;
    [SerializeField] private Player _targetPlayer;
    [SerializeField] private GameConstants.GameObjectColor _color;

	// Use this for initialization
	[UsedImplicitly]
    void Start () {
	    if (_targetPlayer == null)
	    {
	        _targetPlayer = FindObjectOfType<Player>();
	    }
    
	}
	
	// Update is called once per frame
    [UsedImplicitly]
	void FixedUpdate ()
    {
        if (_targetPlayer == null)
        {
            return;
        }
        transform.position = Vector3.MoveTowards(transform.position, _targetPlayer.transform.position,
            Time.fixedDeltaTime*_movementSpeed);
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

    public void SetColor(GameConstants.GameObjectColor newColor)
    {
        _color = newColor;
    }

    public int GetDamage()
    {
        return _damage;
    }
}
