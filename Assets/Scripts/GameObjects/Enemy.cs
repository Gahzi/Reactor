using System;
using Assets.Scripts;
using Assets.Scripts.GameObjects;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

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

    public void OnTouch(BaseEventData e)
    {
        Debug.Log("Touched: " + Time.time);
    }

    public void OnTouchEnded(BaseEventData e)
    {
        Debug.Log("Touch Ended: " + Time.time);
    }

    public void OnMoved(BaseEventData e)
    {
        PointerEventData ped = (e is PointerEventData) ? (ped = (PointerEventData) e) : (ped = null);

        if (ped != null)
        {
            transform.position = transform.position + new Vector3(ped.delta.x,ped.delta.y,0);
        }

        Debug.Log("Moved: " + Time.time);
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
