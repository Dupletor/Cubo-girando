using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Halt : MonoBehaviour {

	// Use this for initialization
	void Start () {
		global.canSpin = true;	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && Physics.Raycast (transform.position, transform.forward, 500))
			global.canSpin = false;
		else
			global.canSpin = true;
	}
}
