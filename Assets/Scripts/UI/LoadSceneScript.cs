using UnityEngine;
using System.Collections;

public class LoadSceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void ButtonPressed () {
			Application.LoadLevel ("MainScene");
	}
}
