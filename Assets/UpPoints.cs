using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpPoints : MonoBehaviour {
	public GameObject NextPoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") {
			NextPoint.SetActive (true);
			gameObject.SetActive (false);
		}
	}
}
