using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayScoreList : MonoBehaviour {

	public GameObject playerScoreEntryPrefab;
	ScoreBoard scoreBoard;

	// Use this for initialization
	void Start () {
	scoreBoard = GameObject.FindObjectOfType<ScoreBoard> ();


	}
	
	// Update is called once per frame
	void Update () {
		while (this.transform.childCount>0) {
			Transform c = this.transform.GetChild(0);
			c.SetParent(null);
			Destroy (c.gameObject);
		}
		string[] names = scoreBoard.GetPlayerNames ();
		foreach(string name in names) {
			GameObject go = (GameObject)Instantiate(playerScoreEntryPrefab);
			go.transform.SetParent (this.transform);
			go.transform.Find ("Username").GetComponent<Text>().text = name;
			go.transform.Find ("Kills").GetComponent<Text>().text = scoreBoard.GetScore (name, "kills").ToString();
			
		}
	
	}
}
