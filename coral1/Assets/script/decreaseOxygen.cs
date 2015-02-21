using UnityEngine;
using System.Collections;

public class decreaseOxygen : MonoBehaviour {

	public GameObject player;

	private RectTransform rt;
	private Oxygen ox;

	// Use this for initialization
	void Start () {
		rt = this.GetComponent<RectTransform> ();
		//rt.SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, 100f);
		//rt.sizeDelta -= new Vector2 (0f, 100f);
		//Debug.Log (rt.sizeDelta.y);

		ox = player.GetComponent<Oxygen> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
