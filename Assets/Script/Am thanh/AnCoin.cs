using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton3
{
	private static Singleton3 instance = null;
	private Singleton3()
	{
		instance = this;
	}
	public static Singleton3 GetInstance()
	{
		if (instance == null)
		{
			instance = new Singleton3 ();
		}
		return instance;
	}
	public static void DestroyInstance()
	{
		instance = null;
	}
}

public enum Sounds3
{
	BACKGROUND = 0,
	EFFECT = 1
};
public class AnCoin : MonoBehaviour {

	private AudioSource[] soundList;

	static private AnCoin instance = null;

	private GameObject mainCharacter = null;

	private AnCoin()
	{
		instance = this;
	}
	public static AnCoin GetInstance()
	{
		if (instance == null)
		{
			instance = new AnCoin(); 
			Debug.Log("Need create an instance");
		}
		return instance;
	}
	void Start () {

		mainCharacter = GameObject.FindGameObjectWithTag("Player");

		if (mainCharacter != null)
		{
			Plane script = mainCharacter.GetComponent<Plane>();
			script.speed2 = new Vector3(1, 0, 0); 
		}
		soundList = GetComponents<AudioSource> ();
	}

	public void StartMusic(Sounds3 sid)
	{
		int id = (int)sid;
		Debug.Log ("Sound: " + id);
		if (id < soundList.Length) 
		{
			soundList[id].Play ();
		}
	}
}

