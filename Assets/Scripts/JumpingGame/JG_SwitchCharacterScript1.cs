using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JG_SwitchCharacterScript1 : MonoBehaviour {

	// referenses to controlled game objects
	public GameObject tigger, monkey;
	
	// variable contains which avatar is on and active
	int whichAvatarIsOn = 1;

	// Use this for initialization
	void Start () {

		// anable first avatar and disable another one
		tigger.gameObject.SetActive (false);
		monkey.gameObject.SetActive (false);
		

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
			tigger.gameObject.SetActive (false);
			monkey.gameObject.SetActive (true);
			PlayerPrefs.SetString("animal", "monkey");
			Debug.Log("Showing Monkey");
				break;

		// if the second avatar is on
		case 2:

			// then the first avatar is on now
			whichAvatarIsOn = 1;

			// disable the second one and anable the first one
			tigger.gameObject.SetActive (true);
			monkey.gameObject.SetActive (false);
			PlayerPrefs.SetString("animal", "tiger");
			Debug.Log("Showing Tiger");
				break;
		}
			
	}
}
