using UnityEngine;
using System.Collections;

public class Windowmanager : MonoBehaviour {
	public GameObject scoreBoard;


	// Use this for initialization
	void Start () {
		//scoreBoard = GameObject.Find ("Scoreboard panel");
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Tab)){
			scoreBoard.SetActive(!scoreBoard.activeSelf);
	
	}
}
}
