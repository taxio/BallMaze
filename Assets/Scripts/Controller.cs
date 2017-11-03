using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using WebSocketSharp;
using WebSocketSharp.Net;
using WebSocketSharp.Server;

public class Controller : MonoBehaviour {

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
		
	}
}

public class LogWS : WebSocketBehavior{
	protected override void OnMessage(MessageEventArgs e){
		Debug.Log (e.Data);
	}
}
