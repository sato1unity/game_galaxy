using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnor : MonoBehaviour {
	[SerializeField]
	private GameObject enemi;
	private BoxCollider2D box;
	void Awake () {
		box=GetComponent<BoxCollider2D>();
	}
	void Start()
	{
		StartCoroutine (SpawnerEnemi());
	}
	void Update () {
		
	}
	IEnumerator SpawnerEnemi(){
		yield return new WaitForSeconds (Random.Range(1f,2f));
		float minX = -box.bounds.size.x / 2f;
		float maxX = box.bounds.size.x / 2f;
		Vector3 temp = transform.position;
		temp.x = Random.Range (minX, maxX);
		Instantiate (enemi, temp, Quaternion.identity);
		StartCoroutine (SpawnerEnemi());
	}
}














