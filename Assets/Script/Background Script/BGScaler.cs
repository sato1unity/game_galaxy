using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScaler : MonoBehaviour {

	void Start () {
		var startHeight = Camera.main.orthographicSize * 2f;
		//Debug.Log (startHeight);
		var startWitdh = startHeight * Screen.width / Screen.height;
		transform.localScale = new Vector3 (startWitdh, startHeight, 0f);
	}
}
