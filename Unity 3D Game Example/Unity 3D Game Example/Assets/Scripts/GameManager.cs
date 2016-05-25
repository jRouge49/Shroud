using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour {

	public GameObject playerPrefab;
	public Text scoreText;

	private float timeElapsed = 0f;
	private float bestTime = 0f;
	//private float blinkTime = 0f;
	//private bool blink;
	private bool gameStarted;
	public bool stopTime;
	private TimeManager timeManager;
	//private LightSwitch lightSwitch;
	//private StopTime finishTime;
	private GameObject player;
	private bool beatBestTime;

	public float vol = 0.5f;
	private AudioSource source;
	public AudioClip fallSound;

	void Awake(){
		timeManager = GetComponent<TimeManager> ();

		source = GetComponent<AudioSource>();

		//lightSwitch = GetComponent<LightSwitch> ();

		//finishTime = GetComponent<StopTime> ();
	}

	// Use this for initialization
	void Start () {

		Time.timeScale = 0;

		bestTime = (PlayerPrefs.GetFloat ("BestTime")+400f);

		stopTime = false;
	}
	
	// Update is called once per frame
	void Update () {



		if (Time.timeScale == 0) {

			timeManager.ManipulateTime (1, 1f);
		} 
		else if (stopTime == false) {
			timeElapsed += Time.deltaTime;
			scoreText.text = "TIME: " + FormatTime (timeElapsed);
		} 
		//else {
			//lightSwitch.
		//}
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("Hit wall");
		//Time.timeScale = 1;
		stopTime = true;
	}

	//void OnTriggerExit(Collider other) {
		//Debug.Log ("leave wall");
		////Time.timeScale = 1;
		//stopTime = false;
	//}
	
	void OnPlayerFinished(){

			var textColor = beatBestTime ? "#FF0" : "#FFF";

			if (timeElapsed < bestTime) {
				bestTime = timeElapsed;
				PlayerPrefs.SetFloat ("BestTime", bestTime);
				beatBestTime = true;
			}
		}

	string FormatTime(float value){
		TimeSpan t = TimeSpan.FromSeconds (value);

		return string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
	}

}
