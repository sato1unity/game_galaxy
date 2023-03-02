using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBL : MonoBehaviour {
	public float speed;
	private Rigidbody2D myBody;
	void Awake () {
		myBody = GetComponent<Rigidbody2D> ();
	}
	void FixedUpdate () {
		myBody.velocity = new Vector2 (0f,-speed);
	}
	void OnTriggerEnter2D(Collider2D target)
	{
		//if (target.tag == "Player"){
		//	Destroy (target.gameObject);
		//	GamePlayControler.instance.PlaneDiedShowPanel ();
		//}
		if (target.tag == "Bolder") {
			Destroy (gameObject);
		}
	
	}
}















