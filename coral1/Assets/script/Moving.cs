﻿using UnityEngine;
using System.Collections;

public class Moving : MonoBehaviour {
	
	public float speed;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.DownArrow)){
			moveDown();
		}
		
		if(Input.GetKey(KeyCode.UpArrow)){
			moveUp();
		}
		
		if(Input.GetKey(KeyCode.LeftArrow)){
			moveLeft();
		}
		
		if(Input.GetKey(KeyCode.RightArrow)){
			moveRigth();
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
