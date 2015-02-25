using System;
using UnityEngine;
using System.Collections;
using TouchScript.Gestures;

public class drag : MonoBehaviour {

	//public float speed=1;
	private Vector2 originalPosition;


	// Use this for initialization
	void Start () {
		originalPosition = this.transform.position;
		GetComponent<ReleaseGesture>().Released += releasedHandler;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector2 (transform.position.x, transform.position.y);
	}

	private void releasedHandler(object sender, EventArgs e)
	{
		//transform.localPosition = new Vector3(0, startY, 0);
		transform.position = originalPosition;
	}
}
