using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class LightSwitch : MonoBehaviour {
	
	public GameObject flashLight;
	public Text batteryLife;

	private float timeElapsed = 0f;
	private TimeManager batteryDrain;
	private float fullBattery = 100f;
	private bool batteryDead;

	
	// Use this for initialization
	void Start () {
		batteryDrain = GetComponent<TimeManager> ();
		batteryDead = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (flashLight.activeInHierarchy == true) {
			timeElapsed += Time.deltaTime;
			batteryLife.text = "BATTERY LIFE: "+(fullBattery - (1 * timeElapsed));
		}

		if (fullBattery - timeElapsed <= 0){
			flashLight.SetActive(false);
			batteryLife.text = "BATTERY LIFE: 0";
			batteryDead = true;
		}

		if (Input.GetKeyDown (KeyCode.E)) {
			if(batteryDead == false && flashLight.activeInHierarchy ==false){
				flashLight.SetActive(true);
			}
			else{ //if(flashLight.activeInHierarchy == true){
				flashLight.SetActive(false);
			}
			}

	}

	string FormatBattery(float value){
		TimeSpan t = TimeSpan.FromSeconds (value);
		
		return string.Format ("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
	}
}
