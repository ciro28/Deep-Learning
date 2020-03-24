using UnityEngine;
using System;
using System.Threading;
using System.Globalization;
using System.Text;

public class SCL_PositionalControllerInput : MonoBehaviour, SCL_IClientSocketHandlerDelegate {

	public GameObject controlledObject;

	private readonly object positionLock = new object();
	private Vector3 position = new Vector3();

	private SCL_SocketServer socketServer;

	// Use this for initialization
	void Start () {
		Debug.Log("Hello From Me");

		SCL_IClientSocketHandlerDelegate clientSocketHandlerDelegate = this;
		int maxClients = 5;
		string separatorString = "&";
		int portNumber = 13000;
		Encoding encoding = Encoding.UTF8;

		this.socketServer = new SCL_SocketServer(
			clientSocketHandlerDelegate, maxClients, separatorString, portNumber, encoding);

		this.socketServer.StartListeningForConnections();

		Debug.Log (String.Format (
			"Started socket server at {0} on port {1}", 
			this.socketServer.LocalEndPoint.Address, this.socketServer.PortNumber));
	}

	void OnApplicationQuit() {
		Debug.Log ("Cleaning up socket server");
		this.socketServer.Cleanup();
		this.socketServer = null;
	}

	void FixedUpdate() {
		
	}

	// this delegate method will be called on another thread, so use locks for synchronization
	public void ClientSocketHandlerDidReadMessage(SCL_ClientSocketHandler handler, string message)
	{

        Debug.Log("RECEIVED -" + message + "-");
        // Debug.Log("RECEIVED lower: " + message.ToLower());

        Debug.Log(message);
        // message.Trim()
        switch (message.Trim().ToLower())
        {
            case "sad": Debug.Log("sono triste"); break;
            case "happy": Debug.Log("sono felice"); break;
            case "neutral": Debug.Log("sono neutro"); break;
            case "fear": Debug.Log("ho paura"); break;
            case "surprise": Debug.Log("sono sorpreso"); break;
            case "angry": Debug.Log("sono arrabbiato"); break;
            case "noface": Debug.Log("no face found"); break;
            default: Debug.Log("(default) sono neutro: " + message); break;
        }

    }


}
