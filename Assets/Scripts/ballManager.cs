using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Physics.gravity = new Vector3(0, -9.81f*1.5f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -20) {
			Debug.Log ("ball falled");
		}
	}
}
