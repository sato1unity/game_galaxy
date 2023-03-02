using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneBound : MonoBehaviour {
	private float minX,minY,maxX,maxY;
	void Start () {
		Vector3 bounds = Camera.main.ScreenToWorldPoint (new Vector3 (Screen.width, Screen.height, 0f));
		minX = -bounds.x + 0.3f;
		maxX = bounds.x - 0.3f;

		minY = -bounds.y + 0.4f;
		maxY = bounds.y - 0.4f;
	}
	void Update () {
		Vector3 temp = transform.position;//vi tri may bay
		if (temp.x < minX) {
			temp.x = minX;
		}else if (temp.x>maxX){
			temp.x=maxX;
		}
		if (temp.y < minY) {
			temp.y = minY;
		}else if(temp.y>maxY){
			temp.y=maxY;
		}
		transform.position = temp;
	}
}























