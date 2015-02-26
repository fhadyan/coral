using UnityEngine;
using System.Collections;

public class Moving : MonoBehaviour {
	
	public float speed;
	public GameObject diver;

	private Animator anim;
	private bool up,down,right,left =false;
	
	// Use this for initialization
	void Start () {
		anim = diver.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.DownArrow)){
			moveDown();
			down  =true;
		}
		
		if(Input.GetKey(KeyCode.UpArrow)){
			moveUp();
			up = true;
		}
		
		if(Input.GetKey(KeyCode.LeftArrow)){
			moveLeft();
			left = true;
		}
		
		if(Input.GetKey(KeyCode.RightArrow)){
			moveRigth();
			right = true;
		}



		if(Input.GetKeyUp(KeyCode.DownArrow)){
			down = false;
		}
		
		if(Input.GetKeyUp(KeyCode.UpArrow)){
			up = false;
		}
		
		if(Input.GetKeyUp(KeyCode.LeftArrow)){
			left = false;
		}
		
		if(Input.GetKeyUp(KeyCode.RightArrow)){
			right = false;
		}

		if (up && right) {
			anim.SetInteger("ani", 5);
		}else if (down && right) {
			anim.SetInteger("ani", 6);
		}else if (down && left) {
			anim.SetInteger("ani", 7);
		}else if (up && left) {
			anim.SetInteger("ani", 8);
		}else if (up) {
			anim.SetInteger("ani", 1);
		}else if (down) {
			anim.SetInteger("ani", 3);
		}else if (right) {
			anim.SetInteger("ani", 2);
		}else if (left) {
			anim.SetInteger("ani", 4);
		}else{
			anim.SetInteger("ani", 0);
		}
	}
	
	public void moveDown(){
		transform.Translate(Vector2.up * Time.deltaTime * speed*-1);
	}
	
	public void moveUp(){
		transform.Translate(Vector2.up * Time.deltaTime * speed);
		//transform.Rotate (Vector2.up);
	}
	
	public void moveRigth(){
		transform.Translate(Vector2.right * Time.deltaTime * speed);
		//transform.Rotate (Vector2.right);
	}
	
	public void moveLeft(){
		transform.Translate(Vector2.right * Time.deltaTime * speed*-1);
		//transform.Rotate (-Vector2.right);
	}
}
