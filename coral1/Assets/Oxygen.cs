using UnityEngine;
using System.Collections;

public class Oxygen : MonoBehaviour {

	public float oxygenLevel;

	private bool dive = false;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("decreaseOxy", 0, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (dive) {
				
		}
	}

	void decreaseOxy(){
		if (oxygenLevel == 0f) {
			Destroy(this.gameObject);		
		}

		if (dive) {
			oxygenLevel -= 1f;	
		}
	}

	void OnCollisionExit2D(Collision2D col){
		if (col.gameObject.name == "air") {
			dive = true;		
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name == "air") {
			dive = false;		
		}
	}
}
