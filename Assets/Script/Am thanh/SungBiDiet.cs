using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton
{
	private static Singleton instance = null;
	private Singleton()
	{
		instance = this;
	}
	public static Singleton GetInstance()
	{
		if (instance == null)
		{
			instance = new Singleton ();
		}
		return instance;
	}
	public static void DestroyInstance()
	{
		instance = null;
	}
}

public enum Sounds
{
	BACKGROUND = 0,
	EFFECT = 1
};
public class SungBiDiet : MonoBehaviour {

	private AudioSource[] soundList;

	static private SungBiDiet instance = null;

	private GameObject mainCharacter = null;

	private SungBiDiet()
	{
		instance = this;
	}
	public static SungBiDiet GetInstance()
	{
		if (instance == null)
		{
			instance = new SungBiDiet(); 
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

	public void StartMusic(Sounds sid)
	{
		int id = (int)sid;
		Debug.Log ("Sound: " + id);
		if (id < soundList.Length) 
		{
			soundList[id].Play ();
		}
	}
}



