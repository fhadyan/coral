using UnityEngine;
using System.Collections;

public class ActuateMove : MonoBehaviour {

	public GameObject player;
	public int direction; //1 = up, 2 = right, 3 = down, 4= left

	private Moving mv;
	private bool actuate;


	// Use this for initialization
	void Start () {
		mv = player.GetComponent<Moving> ();	

	}
	
	// Update is called once per frame
	void Update () {
		if (actuate) {
			if(direction==1){
				mv.moveUp ();	
			}else if(direction==2){
				mv.moveRigth();
			}else if(direction==3){
				mv.moveDown();
			}else if(direction==4){
				mv.moveLeft();
			}
				
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		actuate = true;
	}

	void OnCollisionExit2D(Collision2D col){
		actuate = false;
	}
}
