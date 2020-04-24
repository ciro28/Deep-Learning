using UnityEngine;
using System;
using System.Threading;
using System.Globalization;
using System.Text;
using UnityEngine.SceneManagement;
using SlimUI.ModernMenu;

public class SCL_PositionalControllerInput : MonoBehaviour, SCL_IClientSocketHandlerDelegate {

    public static string emozione = "noface";
    public GameObject controlledObject;
    public GameObject menu;

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

        // 0 Menu
        // 1 Scena Horror ospedale
        // 2 Scena natura
        // 3 scena spazio

        SCL_PositionalControllerInput.emozione = message.Trim().ToLower();
 
    }


}
