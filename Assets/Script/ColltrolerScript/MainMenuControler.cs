using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuControler : MonoBehaviour {

	public void PlayGameButton()
	{
		Application.LoadLevel ("GamePlay");
	}
	public void QuitButton ()
	{
		Application.Quit ();
	}
}



