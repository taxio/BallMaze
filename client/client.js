$(function () {
  var webSocket = null;
  var isOpen = false;
  var x = 0;
  var y = 0;

  function open() {
    if (webSocket == null) {
      // WebSocket の初期化
      webSocket = new WebSocket("ws://192.168.18.11:3000/");
      // イベントハンドラの設定
      webSocket.onopen = onOpen;
      // webSocket.onmessage = onMessage;
      // webSocket.onclose = onClose;
      webSocket.onerror = onError;
    }
  }

  function onOpen(event) {
    var elem = document.getElementById('sensor');
    elem.innerHTML = "open!!";
    isOpen = true;
    sendData();
  }

  function onError(event) {
    var elem = document.getElementById('sensor');
    elem.innerHTML = "error occr!!";
  }

  open();

  function sendData() {
    webSocket.send(x + "," + y);
    setTimeout(sendData, 50);
  }

  function iosHandleOrientation(event) {
    var orientData = event.accelerationIncludingGravity;
    var elem = document.getElementById('sensor');
    elem.innerHTML = orientData.x + "</br>" + orientData.y;
    x = orientData.x;
    y = orientData.y;
    // if(isOpen){
    //   webSocket.send(orientData.x + ", " + orientData.y + ", " + orientData.z);
    // }
  }

  window.addEventListener("devicemotion", iosHandleOrientation, true);
});
