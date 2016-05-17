using UnityEngine;
using System.Collections;

public class StopTime : MonoBehaviour {

	public bool stopTime;

	void OnTriggerEnter2D(Collider2D other) {
		Rigidbody2D otherBody = other.GetComponent <Rigidbody2D>();
		stopTime = true;
	}
}
