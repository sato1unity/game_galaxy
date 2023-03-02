using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBL : MonoBehaviour {
	public float speed;
	public Vector3 speed2;
	private Rigidbody2D myBody;
	void Awake () {
		myBody = GetComponent<Rigidbody2D> ();
	}
	void FixedUpdate () {
		myBody.velocity = new Vector2 (0f,speed);
	}
	void OnTriggerEnter2D(Collider2D target){
		if (target.tag == "Enemi") {
			Destroy (target.gameObject);
			Destroy (gameObject);
			//Plane.plane.Congdiem ();
			EnemiNo.GetInstance().StartMusic(Sounds2.EFFECT);
			EnemiNo.GetInstance().StartMusic(Sounds2.BACKGROUND);
		}
		if (target.tag == "TopBolder") {
			Destroy (gameObject);
		}
		if (target.tag == "Stone") {
			Destroy (target.gameObject);
			Destroy (gameObject);
			EnemiNo.GetInstance().StartMusic(Sounds2.EFFECT);
			EnemiNo.GetInstance().StartMusic(Sounds2.BACKGROUND);
		}
	}
}
