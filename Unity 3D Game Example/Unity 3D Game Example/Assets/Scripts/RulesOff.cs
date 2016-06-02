using UnityEngine;
using System.Collections;



public class RulesOff : MonoBehaviour {

	public GameObject rules;

	void OnTriggerEnter(Collider other) {
		Rigidbody2D otherBody = other.GetComponent <Rigidbody2D> ();
		Debug.Log ("Turn rules off");
		if (rules.activeInHierarchy == true){
			rules.SetActive (false);
		}
	}
}
