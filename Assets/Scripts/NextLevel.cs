﻿using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
	void OnTriggerEnter2D(Collider2D Other)
	{
		if(Other.gameObject.tag=="Boy")
		{
			Debug.Log ("Next");
			Application.Quit ();
		}

	}
}
