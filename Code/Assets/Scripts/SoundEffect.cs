using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundEffect : MonoBehaviour {

	public AudioClip sound;
	public Button button1;
	public Button button2;
	public Button button3;
	public Button button4;
	public Button button5;
	public Button button6;
	public Button button7;
	public Button button8;
	private AudioSource source { get {return GetComponent<AudioSource>();}}

	// Use this for initialization
	void Start () {
		gameObject.AddComponent<AudioSource>();
		source.clip = sound;
		source.playOnAwake = false;

		button1.onClick.AddListener (() => PlaySound ());
		button2.onClick.AddListener (() => PlaySound ());
		button3.onClick.AddListener (() => PlaySound ());
		button4.onClick.AddListener (() => PlaySound ());
		button5.onClick.AddListener (() => PlaySound ());
		button6.onClick.AddListener (() => PlaySound ());
		button7.onClick.AddListener (() => PlaySound ());
		button8.onClick.AddListener (() => PlaySound ());
	}


	void PlaySound()
	{
		source.PlayOneShot (sound);
	}
}
