using UnityEngine;
using System.Collections;

public class LightSwitch : MonoBehaviour {
	
	public GameObject flashLight;
	
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.E)) {
			if(flashLight.activeInHierarchy == false){
				flashLight.SetActive(true);
			}
			else{ //if(flashLight.activeInHierarchy == true){
				flashLight.SetActive(false);
			}
			
			//flashLight.SetActive (!flashLight.activeSelf);
			
		}
	}
}
