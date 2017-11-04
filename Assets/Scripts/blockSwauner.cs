using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockSwauner : MonoBehaviour {

	public GameObject blockPrefab;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 10; i++) {
			GameObject block = Instantiate (blockPrefab,
				new Vector3(Random.Range(-10f, 10f), 1f, Random.Range(-10f, 10f)),
				Quaternion.identity
			);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
