﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class IlluminateSwitch : MonoBehaviour {

	public bool lightsOn;

	public GameObject light1;
	public GameObject light2;
	public GameObject light3;
	public GameObject light4;
	public GameObject light5;
	public GameObject light6;
	public GameObject light7;
	public GameObject light8;
	public GameObject light9;
	public GameObject light10;
	public GameObject light11;
	public GameObject light12;
	public GameObject light13;
	public GameObject light14;
	public GameObject light15;

	void Start () {
		lightsOn = false;
		light1.SetActive (false);
		light2.SetActive (false);
		light3.SetActive (false);
		light4.SetActive (false);
		light5.SetActive (false);
		light6.SetActive (false);
		light7.SetActive (false);
		light8.SetActive (false);
		light9.SetActive (false);
		light10.SetActive (false);
		light11.SetActive (false);
		light12.SetActive (false);
		light13.SetActive (false);
		light14.SetActive (false);
		light15.SetActive (false);
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("Hit wall 1");
		//Time.timeScale = 1;
		light1.SetActive (true);
		light2.SetActive (true);
		light3.SetActive (true);
		light4.SetActive (true);
		light5.SetActive (true);
		light6.SetActive (true);
		light7.SetActive (true);
		light8.SetActive (true);
		light9.SetActive (true);
		light10.SetActive (true);
		light11.SetActive (true);
		light12.SetActive (true);
		light13.SetActive (true);
		light14.SetActive (true);
		light15.SetActive (true);
	}
}

