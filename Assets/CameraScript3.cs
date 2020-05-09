using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript3 : MonoBehaviour {
   
	public Material skySpazio;
	public Material skyNatura;
   

   
    public GameObject Natura;
    public GameObject OspedaleMain;
    public GameObject Spazio;

    public GameObject cameraOspedale;
    public GameObject cameraSpazio;
    public GameObject cameraNatura;

    public int cameraPositionCounter;

    AudioListener cameraOspedaleAudioLis;
    AudioListener cameraSpazioAudioLis;
    AudioListener cameraNaturaAudioLis;

    // Start is called before the first frame update
    void Start () {
        //Get Camera Listeners

        cameraOspedaleAudioLis = cameraOspedale.GetComponent<AudioListener> ();
        cameraSpazioAudioLis = cameraSpazio.GetComponent<AudioListener> ();
        cameraNaturaAudioLis = cameraNatura.GetComponent<AudioListener> ();
        //Camera Position Set
        cameraPositionChange (0);
    }

    // Update is called once per frame
    void Update () {
        switchCamera ();
    }

    public void cameraPositonM () {
        cameraChangeCounter0 ();
        cameraChangeCounter1 ();
        cameraChangeCounter2 ();
    }

    void switchCamera () {
        if (Input.GetKeyDown (KeyCode.O)) {
            cameraChangeCounter0 ();
        }
        if (Input.GetKeyDown (KeyCode.N)) {
            cameraChangeCounter1 ();
        }
        if (Input.GetKeyDown (KeyCode.M)) {
            cameraChangeCounter2 ();
        }
    }

    void cameraChangeCounter0 () {
        cameraPositionCounter = PlayerPrefs.GetInt ("CameraPosition");
        cameraPositionCounter = 0;
        cameraPositionChange (cameraPositionCounter);
    }

    void cameraChangeCounter1 () {
        cameraPositionCounter = PlayerPrefs.GetInt ("CameraPosition");
        cameraPositionCounter = 1;
        cameraPositionChange (cameraPositionCounter);
    }

    void cameraChangeCounter2 () {
        cameraPositionCounter = PlayerPrefs.GetInt ("CameraPosition");
        cameraPositionCounter = 2;

        cameraPositionChange (cameraPositionCounter);
    }

    void cameraPositionChange (int camPosition) {
        if (camPosition > 2) {
            camPosition = 0;
        }

        //Set camera position database
        PlayerPrefs.SetInt ("CameraPosition", camPosition);

        //Set camera position 1
        if (camPosition == 0) {
            cameraOspedale.SetActive (true);
            cameraOspedaleAudioLis.enabled = true;

            cameraSpazioAudioLis.enabled = false;
            cameraSpazio.SetActive (false);

            cameraNatura.SetActive (false);
            cameraNaturaAudioLis.enabled = false;

            OspedaleMain.SetActive (true);
            Natura.SetActive (false);
            Spazio.SetActive (false);
        }

        //Set camera position 2
        if (camPosition == 1) {
            cameraNatura.SetActive (true);
            cameraNaturaAudioLis.enabled = true;
            cameraSpazio.SetActive (false);
            cameraSpazioAudioLis.enabled = false;

            cameraOspedaleAudioLis.enabled = false;
            cameraOspedale.SetActive (false);
    
            Natura.SetActive (true);
            OspedaleMain.SetActive (false);
            Spazio.SetActive (false);


             RenderSettings.skybox = skyNatura;
        }

        if (camPosition == 2) {
            cameraSpazio.SetActive (true);
            cameraSpazioAudioLis.enabled = true;

            cameraOspedaleAudioLis.enabled = false;
            cameraOspedale.SetActive (false);
            cameraNatura.SetActive (false);
            cameraNaturaAudioLis.enabled = false;

            Spazio.SetActive (true);
            OspedaleMain.SetActive (false);
            Natura.SetActive (false);

             RenderSettings.skybox = skySpazio;
        }

    }
}