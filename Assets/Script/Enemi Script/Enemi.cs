using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemi : MonoBehaviour {
	public float enemiSpeed;
	private Rigidbody2D myBody;
	[SerializeField]
	private GameObject bullet;
	void Awake () {
		myBody = GetComponent<Rigidbody2D> ();
	}
	void Start()
	{
		StartCoroutine (EnemiShoot());
	}
	void FixedUpdate () {
		myBody.velocity = new Vector2 (0f,-enemiSpeed);
	}
	IEnumerator EnemiShoot(){
		
		//yield return new WaitForSeconds (0.2f);
		Vector3 temp = transform.position;
		temp.y -= 0.5f;
		Instantiate (bullet, temp, Quaternion.identity);
		yield return new WaitForSeconds (Random.Range (1f, 3f));
		StartCoroutine (EnemiShoot());
	}
	void OnTriggerEnter2D(Collider2D target)
	{
		//if(target.tag=="Player"){
		//	Destroy (target.gameObject);
		//	GamePlayControler.instance.PlaneDiedShowPanel ();
		//}
		if (target.tag == "Bolder") {
			Destroy (gameObject);
		}
	}
}











