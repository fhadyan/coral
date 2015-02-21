using UnityEngine;
using System.Collections;

public class Oxygen : MonoBehaviour {

	public float maxOxygen;
	public GameObject oxygenBar;

	private bool dive = false;
	private RectTransform rt;
	private float maxBar;
	private float oxygenLevel;

	// Use this for initialization
	void Start () {
		rt = oxygenBar.GetComponent<RectTransform> ();
		maxBar = rt.sizeDelta.y;
		oxygenLevel = maxOxygen;
		InvokeRepeating ("decreaseOxy", 0, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		//if (dive) {	}
	}

	void decreaseOxy(){
		if (oxygenLevel == 0f) {
			Destroy(this.gameObject);		
		}

		if (dive) {
			oxygenLevel -= 1f;	
			rt.sizeDelta -= new Vector2(0f, 1/maxOxygen * maxBar);
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
