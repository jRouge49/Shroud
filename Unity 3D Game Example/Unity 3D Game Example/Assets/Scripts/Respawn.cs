using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

	//public Transform player;

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("Fell");
		
		Rigidbody2D otherBody = other.GetComponent <Rigidbody2D>();
		otherBody.velocity = new Vector3 (1.32f, 25.62f, 26.3f);
}
}