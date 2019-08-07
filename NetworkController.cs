using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
public class NetworkController : NetworkManager {

	// Use this for initialization
	public string port;
	public int portint;
	public InputField inputport;
	public InputField inputip;
	public void Update(){
		port = inputport.textComponent.text;
		portint = int.Parse(port);

		NetworkManager.singleton.networkAddress = inputip.textComponent.text;
		NetworkManager.singleton.networkPort=portint;
	}
	public void StartupHost(){
		SetPort();
		NetworkManager.singleton.StartHost();
	}

	void SetPort(){
		NetworkManager.singleton.networkPort=portint;
	}

	public void JoinGame(){
		SetIPAdress();
		SetPort();
		NetworkManager.singleton.StartClient();
	}

	void SetIPAdress(){
		string ipadress = inputip.textComponent.text;
		NetworkManager.singleton.networkAddress=ipadress;
	}
}
