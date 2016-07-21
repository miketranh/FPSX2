using UnityEngine;
using System.Collections;

public class EndBox : MonoBehaviour {

private void OnTriggerEnter(Collider other)
	{
		GameObject.Find ("player").SendMessage ("Finish");
	}
}
