using UnityEngine;
using System.Collections;

public class drag : MonoBehaviour {

	public float speed=1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.touchCount > 0)&&(Input.GetTouch(0).phase == TouchPhase.Moved )) {
			Vector2 touchPosition = Input.GetTouch(0).deltaPosition;
			transform.Translate(-touchPosition.x*speed,-touchPosition.y*speed,0);
		}
	}
}
