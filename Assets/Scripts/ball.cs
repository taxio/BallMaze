using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

	public bool isGoal = false;

	// Use this for initialization
	void Start () {
		Physics.gravity = new Vector3(0, -9.81f*1.5f, 0);
	}
	
	// Update is called once per frame
	void Update () {

		// 落下判定
		if (transform.position.y < -20) {
			Destroy (gameObject);
		}

		// ゴール判定
		if (isGoal) {
			Debug.Log ("goal!!!");
		}
	}


	void OnCollisionEnter (Collision col){
		if(col.transform.CompareTag("goal")){
			isGoal = true;
		}
	}
}
