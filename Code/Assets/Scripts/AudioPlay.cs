using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AudioPlay : MonoBehaviour {
	public AudioSource Audio;
	public Button On;
	public Button Off;

	float volume;
	// Use this for initialization
	void Start () {
		Audio = Audio.GetComponent<AudioSource> ();
		//buttonSound = buttonSound.GetComponent<AudioClip> ();
		On = GameObject.Find("On").GetComponent<Button> ();
		Off = GameObject.Find("Off").GetComponent<Button> ();
		Audio.Play ();
		Audio.volume = (float)1.0;
		On.gameObject.SetActive(true);
		Off.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnPress(){
		Audio.volume = (float)0.0;
		Off.gameObject.SetActive (true);
		On.gameObject.SetActive (false);
		//On.enabled = false;
	}

	public void OffPress(){
		Audio.volume = (float)1.0;
		Off.gameObject.SetActive (false);
		On.gameObject.SetActive (true);
		//Off.enabled = false;
	}
	
}
