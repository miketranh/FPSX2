using UnityEngine;
using System.Collections;

public class FPSShooting : MonoBehaviour {

	public GameObject bullet_prefab;
	float bulletImpulse = 30f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1") ){
			Camera cam = Camera.main;
			GameObject thebullet =(GameObject)Instantiate(bullet_prefab, transform.position, transform.rotation);
			thebullet.rigidbody.AddForce( cam.transform.forward * bulletImpulse, ForceMode.Impulse);
	
	}
}
}
