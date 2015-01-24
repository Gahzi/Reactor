using JetBrains.Annotations;
using UnityEngine;
using System.Collections;

public class Road : MonoBehaviour
{

    public Transform[] NavTrans;

	// Use this for initialization
    [UsedImplicitly]
	void Start () {
        if (NavTrans.Length == 0)
        {
            Debug.LogError("Road named: " + gameObject.name + " has no nav markers");
        }
	}
	
	// Update is called once per frame
    [UsedImplicitly]
    void Update () {
	
	}
}
