using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JG_SwitchCharacterScript : MonoBehaviour {

	// referenses to controlled game objects
	public GameObject pig, cat, tiger, monkey;
	
	// variable contains which avatar is on and active
	int whichAvatarIsOn = 1;

	// Use this for initialization
	void Start () {

		// anable first avatar and disable another one
		pig.gameObject.SetActive (false);
		cat.gameObject.SetActive (false);
		

	}

	// public method to switch avatars by pressing UI button
	public void SwitchAvatar()
	{

		// processing whichAvatarIsOn variable
		switch (whichAvatarIsOn) {

		// if the first avatar is on
		case 1:

			// then the second avatar is on now
			whichAvatarIsOn = 2;

			// disable the first one and anable the second one
			pig.gameObject.SetActive (false);
			cat.gameObject.SetActive (true);
			PlayerPrefs.SetString("animal", "cat");
			Debug.Log("Showing Cat");
				break;

		// if the second avatar is on
		case 2:

			// then the first avatar is on now
			whichAvatarIsOn = 1;

			// disable the second one and anable the first one
			pig.gameObject.SetActive (true);
			cat.gameObject.SetActive (false);
			PlayerPrefs.SetString("animal", "pig");
			Debug.Log("Showing Pig");
				break;
		}
			
	}
}
