using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {
	public float range = 100.0f;
	public float cooldown = 0.2f;
	float cooldownRemaining = 0;
	public GameObject debrisPrefab;
	public float damage =10f;

	public Animation am;
	public AnimationClip shoot;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		cooldownRemaining -= Time.deltaTime;
		if (Input.GetMouseButton (0) && cooldownRemaining<= 0) {

			Ray ray = new Ray( Camera.main.transform.position, Camera.main.transform.forward);
			RaycastHit hitInfo;

		if( Physics.Raycast(ray, out hitInfo, range) ){
			Vector3 hitPoint = hitInfo.point;
				GameObject go = hitInfo.collider.gameObject;
				Debug.Log ("Hit Object: " + go.name);
				Debug.Log ("Hit Point: " + hitPoint);

				Enemy h = go.GetComponent<Enemy>();
				if(h != null){
					h.ReceiveDamage(damage);
				}

				if(debrisPrefab != null){
				Instantiate(debrisPrefab, hitPoint,Quaternion.identity);
			}
		}
	
	}
}
}
