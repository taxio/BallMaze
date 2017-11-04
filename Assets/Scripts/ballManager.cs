using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballManager : MonoBehaviour {

	public GameObject ballPrefab;
	public int ballRemain = 2;		// ボール残機
	GameObject ballInst = null;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		// ボールのインスタンスが存在しない時に生成
		if (ballInst == null) {
			if (ballRemain > 0) {
				ballInst = Instantiate (ballPrefab,
					new Vector3 (-17f, 5f, 0f),
					Quaternion.identity
				);
				ballRemain -= 1;
			} else {
				Debug.Log ("Game Over");
			}
		}
	}
}
