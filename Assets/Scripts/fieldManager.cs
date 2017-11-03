using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fieldManager : MonoBehaviour {

	float x = 0;
	float z = 0;
	const float power = 20;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			z -= Time.deltaTime * power;
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			z += Time.deltaTime * power;
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			x += Time.deltaTime * power;
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			x -= Time.deltaTime * power;
		}

		transform.rotation = Quaternion.Euler (x, 0, z);
	}
}
