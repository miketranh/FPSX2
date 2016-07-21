using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class ScoreBoard : MonoBehaviour {
	//Multiple Score with Username
	Dictionary<string, Dictionary<string, int>> playerScores;

	void Start(){
		SetScore("Marine","kills", 90);
		SetScore("Marine1","kills", 10);
		SetScore("Marine2","kills", 90);
		SetScore("Marine3","kills", 9);
		SetScore("Marine4","kills", 2);
		SetScore("Marine5","kills", 91);

		Debug.Log( GetScore("Marine","kills"));


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