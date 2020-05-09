

	var cam1 : Camera;
	var cam2 : Camera;
 
 function Start() {
     cam1.enabled = true;
     cam2.enabled = false;
 }
 
 function Update() {
 
     if (Input.GetKeyDown(KeyCode.N)) {
         cam1.enabled = !cam1.enabled;
         cam2.enabled = !cam2.enabled;
     }
	 else if(Input.GetKeyDown(KeyCode.H)){
		 cam1.enabled = !cam1.enabled;
         cam2.enabled = !cam2.enabled;
	 }
 }

 /*
 var cam1: Camera;
 var cam2: Camera;
 var cam3: Camera;
 
 function Start() {
     cam1.enabled = true;
     cam2.enabled = false;
     cam3.enabled = false;
 }
 
 function Update() {
 
     if (Input.GetKeyDown(KeyCode.V) && (cam1.enabled == true || cam3.enabled == true)) {
     cam1.enabled = false;
     cam2.enabled = true;
     cam3.enabled = false;
     }
     else if (Input.GetKeyDown(KeyCode.B) && (cam2.enabled == true || cam1.enabled == true)) {
     cam1.enabled = false;
     cam2.enabled = false;
     cam3.enabled = true;
     }
     else if (Input.GetKeyDown(KeyCode.C) && (cam2.enabled == true || cam3.enabled == true)) {
     cam1.enabled = true;
     cam2.enabled = false;
     cam3.enabled = false;
     }
 }*/





/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour {

    public GameObject cameraOne;
    public GameObject cameraTwo;

    AudioListener cameraOneAudioLis;
    AudioListener cameraTwoAudioLis;

    // Use this for initialization
    void Start()
    {

        //Get Camera Listeners
        cameraOneAudioLis = cameraOne.GetComponent<AudioListener>();
        cameraTwoAudioLis = cameraTwo.GetComponent<AudioListener>();

        //Camera Position Set
        cameraPositionChange(PlayerPrefs.GetInt("CameraPosition"));
    }

    // Update is called once per frame
    void Update()
    {
        //Change Camera Keyboard
        switchCamera();
    }

    //UI JoyStick Method
    public void cameraPositonM()
    {
        cameraChangeCounter();
    }

    //Change Camera Keyboard
    void switchCamera()
    {
        if (Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.LeftAlt) || Input.GetKeyDown(KeyCode.RightAlt))
        {
            cameraChangeCounter();
        }
    }

    //Camera Counter
    void cameraChangeCounter()
    {
        int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
        cameraPositionCounter++;
        cameraPositionChange(cameraPositionCounter);
    }

    //Camera change Logic
    void cameraPositionChange(int camPosition)
    {
        if (camPosition > 1)
        {
            camPosition = 0;
        }

        //Set camera position database
        PlayerPrefs.SetInt("CameraPosition", camPosition);

        //Set camera position 1
        if (camPosition == 0)
        {
            cameraOne.SetActive(true);
            cameraOneAudioLis.enabled = true;

            cameraTwoAudioLis.enabled = false;
            cameraTwo.SetActive(false);
        }

        //Set camera position 2
        if (camPosition == 1)
        {
            cameraTwo.SetActive(true);
            cameraTwoAudioLis.enabled = true;

            cameraOneAudioLis.enabled = false;
            cameraOne.SetActive(false);
        }

    }
}*/