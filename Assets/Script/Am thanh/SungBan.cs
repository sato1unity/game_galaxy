using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton1
{
	private static Singleton1 instance = null;
	private Singleton1()
	{
		instance = this;
	}
	public static Singleton1 GetInstance()
	{
		if (instance == null)
		{
			instance = new Singleton1 ();
		}
		return instance;
	}
	public static void DestroyInstance()
	{
		instance = null;
	}
}

public enum Sounds1
{
	BACKGROUND = 0,
	EFFECT = 1
};
public class SungBan : MonoBehaviour {

	private AudioSource[] soundList;

	static private SungBan instance = null;

	private GameObject mainCharacter = null;

	private SungBan()
	{
		instance = this;
	}
	public static SungBan GetInstance()
	{
		if (instance == null)
		{
			instance = new SungBan(); 
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

	public void StartMusic(Sounds1 sid)
	{
		int id = (int)sid;
		Debug.Log ("Sound: " + id);
		if (id < soundList.Length) 
		{
			soundList[id].Play ();
		}
	}
}

