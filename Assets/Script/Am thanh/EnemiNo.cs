using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton2
{
	private static Singleton2 instance = null;
	private Singleton2()
	{
		instance = this;
	}
	public static Singleton2 GetInstance()
	{
		if (instance == null)
		{
			instance = new Singleton2 ();
		}
		return instance;
	}
	public static void DestroyInstance()
	{
		instance = null;
	}
}

public enum Sounds2
{
	BACKGROUND = 0,
	EFFECT = 1
};
public class EnemiNo : MonoBehaviour {

	private AudioSource[] soundList;

	static private EnemiNo instance = null;

	private GameObject mainCharacter = null;

	private EnemiNo()
	{
		instance = this;
	}
	public static EnemiNo GetInstance()
	{
		if (instance == null)
		{
			instance = new EnemiNo(); 
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

	public void StartMusic(Sounds2 sid)
	{
		int id = (int)sid;
		Debug.Log ("Sound: " + id);
		if (id < soundList.Length) 
		{
			soundList[id].Play ();
		}
	}
}
