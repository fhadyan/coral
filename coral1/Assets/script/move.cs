using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate(Vector2.up * Time.deltaTime * speed*-1);
		}

		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(Vector2.up * Time.deltaTime * speed);
		}

		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate(Vector2.right * Time.deltaTime * speed*-1);
		}
		
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Translate(Vector2.right * Time.deltaTime * speed);
		}
	}
}