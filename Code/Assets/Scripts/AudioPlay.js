#pragma strict

function Start () {
	var audio : AudioSource = GetComponent.<AudioSource>();
	var volume : float;
	audio.Play();
	audio.volume = 0.0;
}

function Update () {

}