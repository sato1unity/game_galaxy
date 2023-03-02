using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plane : MonoBehaviour {
	public float planespeed;
	public Vector3 speed2;
	public Text Scores;
	public float diem;
	public Text Blood;
	public int mau;
	public Text Coin;
	public float tien;
	private Rigidbody2D myBody;
	[SerializeField]
	private GameObject Bullet;
	private bool canShoot=true;
	public static Plane plane;
	void Awake(){
		myBody = GetComponent<Rigidbody2D> ();
	}
	void FixedUpdate () {
		PlaneMovement();
	}
	void Update()
	{
		if (Input.GetKey (KeyCode.Mouse0)) {
			if (canShoot) {
				BanSung ();
			}
			//Instantiate (Bullet, transform.position, Quaternion.identity);//dua vien dan vao, vi tri tai cai sung, khong cho xoay
		}
	}

	void OnTriggerEnter2D(Collider2D target)
	{
		if (target.tag == "BTC") {
			tien += 5f;
			Coin.text = "Coin: " + tien.ToString ();
			Destroy (target.gameObject);
			AnCoin.GetInstance().StartMusic(Sounds3.EFFECT);
			AnCoin.GetInstance().StartMusic(Sounds3.BACKGROUND);
		}
		if (target.tag == "ETH") {
			tien += 4f;
			Coin.text = "Coin: " + tien.ToString ();
			Destroy (target.gameObject);
			AnCoin.GetInstance().StartMusic(Sounds3.EFFECT);
			AnCoin.GetInstance().StartMusic(Sounds3.BACKGROUND);
		}

		if (target.tag == "Enemi") {
			mau =mau- 6;
			Blood.text = "Health: " + mau.ToString ();
			Destroy (target.gameObject);
			EnemiNo.GetInstance().StartMusic(Sounds2.EFFECT);
			EnemiNo.GetInstance().StartMusic(Sounds2.BACKGROUND);
		}
		if (target.tag == "RedBL") {
			mau =mau- 5;
			Destroy (target.gameObject);
			Blood.text = "Health: " + mau.ToString ();
			EnemiNo.GetInstance().StartMusic(Sounds2.EFFECT);
			EnemiNo.GetInstance().StartMusic(Sounds2.BACKGROUND);
		}
		if (target.tag == "Stone") {
			mau =mau- 6;
			Destroy (target.gameObject);
			Blood.text = "Health: " + mau.ToString ();
			EnemiNo.GetInstance().StartMusic(Sounds2.EFFECT);
			EnemiNo.GetInstance().StartMusic(Sounds2.BACKGROUND);
		}
		if (target.tag == "Stone1") {
			mau =mau- 4;
			Destroy (target.gameObject);
			Blood.text = "Health: " + mau.ToString ();
			EnemiNo.GetInstance().StartMusic(Sounds2.EFFECT);
			EnemiNo.GetInstance().StartMusic(Sounds2.BACKGROUND);
		}
		if (mau <= 0) {
			mau = 0;
			Blood.text = "Health: " + mau.ToString ();
			Destroy (this.gameObject);
			GamePlayControler.instance.PlaneDiedShowPanel ();
			SungBiDiet.GetInstance().StartMusic(Sounds.EFFECT);
			SungBiDiet.GetInstance().StartMusic(Sounds.BACKGROUND);
		}
	}
	public void Congdiem()
	{
		diem +=8f;
		Scores.text = "Scores: " + diem.ToString ();
	}
	public void BanSung (){
		StartCoroutine (Shoot());
		GamePlayControler.instance.controler=9;
		GamePlayControler.instance.controlerGameplay[0]=1;
		//Debug.Log ("son//////////////////:"+GamePlayControler.instance.controlerGameplay[0]);
		Debug.Log (GamePlayControler.instance.controler);
		SungBan.GetInstance().StartMusic(Sounds1.EFFECT);
		SungBan.GetInstance().StartMusic(Sounds1.BACKGROUND);
	}

	void PlaneMovement(){
		float xAxit = Input.GetAxisRaw ("Horizontal") * planespeed;
		float yAxit = Input.GetAxisRaw ("Vertical") * planespeed;
		myBody.velocity = new Vector2 (xAxit,yAxit);
	}
	IEnumerator Shoot(){
		canShoot = false;
		Vector3 vitri = transform.position;
		vitri.y += 0.6f; 
		Instantiate (Bullet,vitri,Quaternion.identity);
		yield return new WaitForSeconds (0.2f);
		canShoot = true;
	}
}

























