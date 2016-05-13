using UnityEngine;
using System.Collections;

namespace MyScore{
public class Score : MonoBehaviour {
	int score;
	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public int getScore ()
	{
			return score;
	}
	public void setScore(int a)
	{	
		this.score = a;
	}
}
}