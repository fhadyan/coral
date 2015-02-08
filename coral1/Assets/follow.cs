using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour {

	public float speed;
	public float distance;
	public GameObject player;

	private bool moved=false;
	private bool over = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.x + distance <= player.gameObject.transform.position.x) {
			transform.Translate(Vector2.right * Time.deltaTime * speed);
			over=true;
		}
		if (this.transform.position.x - distance >= player.gameObject.transform.position.x) {
			transform.Translate(Vector2.right * Time.deltaTime * speed * -1);	
			over=true;
		}
		if (this.transform.position.y + distance <= player.gameObject.transform.position.y) {
			transform.Translate(Vector2.up * Time.deltaTime * speed);		
			over=true;
		}
		if (this.transform.position.y - distance >= player.gameObject.transform.position.y) {
			transform.Translate(Vector2.up * Time.deltaTime * speed * -1);		
			over=true;
		}

		if ((Input.GetKeyUp (KeyCode.UpArrow) || Input.GetKeyUp (KeyCode.DownArrow) || Input.GetKeyUp (KeyCode.RightArrow) || Input.GetKeyUp (KeyCode.LeftArrow)) && over) {
			Debug.Log("released");
			//Debug.Log(Mathf.Abs(-0.231f));
			//Debug.Log(Mathf.Abs(this.transform.position.x-this.transform.position.x));
			//Debug.Log(this.transform.position.x);
			Debug.Log(Mathf.Abs(this.transform.position.y-player.gameObject.transform.position.y));
			if(Mathf.Abs(this.transform.position.x-player.gameObject.transform.position.x) >= 0.1f){

				moved = true;
				Debug.Log("start");
			}else if(Mathf.Abs(this.transform.position.y-player.gameObject.transform.position.y) >= 0.1f){
				moved = true;
				Debug.Log("start");
			}


		}

		if (moved) {
			if(this.transform.position.x > player.gameObject.transform.position.x){
				transform.Translate(Vector2.right * Time.deltaTime * speed * -1);
			}
			if(this.transform.position.x < player.gameObject.transform.position.x){
				transform.Translate(Vector2.right * Time.deltaTime * speed);
			}
			if(this.transform.position.y > player.gameObject.transform.position.y){
				transform.Translate(Vector2.up * Time.deltaTime * speed * -1);
			}
			if(this.transform.position.y < player.gameObject.transform.position.y){
				transform.Translate(Vector2.up * Time.deltaTime * speed);
			}
			Debug.Log("moving");
		}

		if(((Mathf.Abs(this.transform.position.x-player.gameObject.transform.position.x) <= 0.1f) && (Mathf.Abs(this.transform.position.y-player.gameObject.transform.position.y) <= 0.1f)) && moved){
			moved = false;
			over = false;
			Debug.Log("ok");
		}

		//moved = false;
	}
}
