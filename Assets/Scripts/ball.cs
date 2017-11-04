using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour {

	public bool isGoal = false;
	Text clearText;

	// Use this for initialization
	void Start () {
		Physics.gravity = new Vector3(0, -9.81f*1.5f, 0);
		clearText = GameObject.Find("Canvas/Text").GetComponent<Text> ();
		clearText.text = "";
	}
	
	// Update is called once per frame
	void Update () {

		// 落下判定
		if (transform.position.y < -20 && isGoal == false) {
			Destroy (gameObject);
		}

		// ゴール判定
		if (isGoal) {
			Debug.Log ("goal!!!");
			clearText.text = "Game Clear!!";
		}
	}


	void OnCollisionEnter (Collision col){
		if(col.transform.CompareTag("goal")){
			isGoal = true;
		}
	}
}
