using UnityEngine;
using System.Collections;

public class Illuminate : MonoBehaviour {

	public IlluminateSwitch illuminateSwitch;
	public GameObject light;

	// Use this for initialization
	void Start () {
		illuminateSwitch = GetComponent<IlluminateSwitch> ();
		//light.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (illuminateSwitch.lightsOn == true) {
			light.SetActive (true);
		}
	}
}
