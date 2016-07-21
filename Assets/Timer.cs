using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {
	public Text timerText;
	private float startTime;
	//private bool finished;
	private float finishedtime = 60.0f;

	// Use this for initialization
	void Start () {
		startTime = Time.time;

	}
	
	// Update is called once per frame
	void Update () {
		if (finishedtime - Time.time <= 0.0f) {
			timerText.text = "Game Over";
		} else {
			float t = Time.time - startTime;
			string minutes = ((int)t / 60).ToString ();
			string seconds = (t % 60).ToString ("f2");
			//f2 define only 2 float

			timerText.text = minutes + ":" + seconds;
		}
	
	}
//	public void Finish()
//	{
//			finished = true;
//			timerText.text = "Game Over";
//}
}