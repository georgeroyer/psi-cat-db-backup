﻿using UnityEngine;
using System.Collections;

public class Pickupable : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		SendMessageUpwards ("OnPickableCollision", collision, SendMessageOptions.DontRequireReceiver);
	}
}