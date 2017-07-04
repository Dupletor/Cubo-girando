﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spin : MonoBehaviour {
	// Use this for initialization
	void Start () {
		global.canSpin = true;	
	}
	
	// Update is called once per frame
	void Update () {
		if(global.canSpin)
			transform.Rotate(Time.deltaTime*100, -100*Time.deltaTime, 50*Time.deltaTime);
	}
}

public static class global {
	public static bool canSpin;
}