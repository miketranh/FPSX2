using UnityEngine;
using System.Collections;

public class Bullets : MonoBehaviour {

	float lifespan =2.0f;
	public GameObject fireEffect;
	private int score;

	// Use this for initialization
	void Start () {
		score = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		lifespan -= Time.deltaTime;
		if (lifespan <= 0) {
			Hit();
		}
	}

	/*void Awake() {
			InvokeRepeating("CheckOffscreen", 4f, 4f);
		}*/
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Enemy") {
			collision.gameObject.tag ="Untagged";
			Instantiate(fireEffect,collision.transform.position,Quaternion.identity);
			score = score + 1;
			}

			//destroy object that hitting
			//Destroy(collision.gameObject);
			//destroy bullet
			Destroy(gameObject);
		}

	void Hit(){
		Destroy (gameObject);
	}

	/*void CheckOffscreen() {
			if(Utils.ScreenBoundsCheck(collider.bounds, BoundsTest.offScreen) != Vector3.zero) {
				Destroy(gameObject);

	}*/
}
