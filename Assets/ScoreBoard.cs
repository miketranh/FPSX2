using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class ScoreBoard : MonoBehaviour {
	private int _score = 100;
	//Multiple Score with Username
	Dictionary<string, Dictionary<string, int>> playerScores;

	public int score {
		get {
			return (_score);
		}
		set {
			_score = value;
		}
	}

	void Start(){
		SetScore("Marine1","kill",10);

	}

	void Init(){
		if (playerScores != null)
			return;
		playerScores = new Dictionary<string, Dictionary<string, int>> ();
	}

	public int GetScore(string username, string scoreType){
		Init(); 
		if(playerScores.ContainsKey(scoreType) == false){
		   return 0;
		}
		return playerScores[username][scoreType];
	}
	public void SetScore(string username, string scoreType, int value){
		Init ();
		if (playerScores.ContainsKey (username) == false) {
			playerScores [username] = new Dictionary<string, int> (); 
		}
		playerScores[username][scoreType] = value;
	}
	public void ChangeScore(string username, string scoreType, int amount){
		Init ();
		int currScore = GetScore (username, scoreType);
		SetScore (username, scoreType, currScore + amount);
	}

	public string[] GetPlayerNames(){
		Init ();
		return playerScores.Keys.ToArray();
	
}
}