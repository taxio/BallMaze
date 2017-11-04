using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using WebSocketSharp;
using WebSocketSharp.Net;
using WebSocketSharp.Server;

public class fieldManager : MonoBehaviour {

	float x = 0f;
	float z = 0f;
	const float power = 20f;

	WebSocketServer server;

	// Use this for initialization
	void Start () {

		server = new WebSocketServer (3000);
		server.AddWebSocketService<LogWS> ("/");
		server.Start ();

		Debug.Log ("WS server start!!");
		
	}

	void OnDestroy(){
		server.Stop ();
		server = null;
		Debug.Log ("stop WS server");
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

		z = LogWS.z * 90f / 9.8f * -1f;
		x = LogWS.x * 90f / 9.8f;

		transform.rotation = Quaternion.Euler (x, 0, z);
	}
}

public class LogWS : WebSocketBehavior{
	public static float x = 0f;
	public static float z = 0f;

	protected override void OnMessage(MessageEventArgs e){
		string[] data = e.Data.Split (',');
		z = float.Parse (data [0]);
		x = float.Parse (data [1]);
	}
}