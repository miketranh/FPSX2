using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public float hitPoints = 100f;
	public void ReceiveDamage(float amt){
		hitPoints -= amt;
		if (hitPoints <= 0) {
			Die ();
		}
	}

	void Die(){
		Destroy (gameObject);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
