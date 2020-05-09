using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch2 : MonoBehaviour
{

    public GameObject cameraOspedale;
    public GameObject cameraNatura;
    public GameObject cameraSpazio;

    AudioListener cameraOspedaleAudioLis;
    AudioListener cameraNaturaAudioLis;
    AudioListener cameraSpazioAudioLis;

    // Use this for initialization
    void Start()
    {

        //Get Camera Listeners
        cameraOspedaleAudioLis = cameraOspedale.GetComponent<AudioListener>();
        cameraNaturaAudioLis = cameraNatura.GetComponent<AudioListener>();
        cameraSpazioAudioLis = cameraSpazio.GetComponent<AudioListener>();

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
    public void cameraPositonM1()
    {
        cameraChangeCounter1();
    }

    public void cameraPositonM2()
    {
        cameraChangeCounter2();
    }

    //Change Camera Keyboard
    void switchCamera()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            cameraChangeCounter1();
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            cameraChangeCounter2();
        }
    }

    //Camera Counter
    void cameraChangeCounter1()
    {
        int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
        cameraPositionCounter++;
        cameraPositionChange(cameraPositionCounter);
    }

    void cameraChangeCounter2()
    {
        int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
        cameraPositionCounter = cameraPositionCounter + 2;
        cameraPositionChange(cameraPositionCounter);
    }

    //Camera change Logic
    void cameraPositionChange(int camPosition)
    {
        if (camPosition > 2)
        {
            camPosition = 0;
        }

        //Set camera position database
        PlayerPrefs.SetInt("CameraPosition", camPosition);

        //Set camera position 1
        if (camPosition == 0)
        {
            cameraOspedale.SetActive(true);
            cameraOspedaleAudioLis.enabled = true;

            cameraNaturaAudioLis.enabled = false;
            cameraNatura.SetActive(false);

            cameraSpazioAudioLis.enabled = false;
            cameraSpazio.SetActive(false);
        }

        if (camPosition == 1)
        {
            cameraNatura.SetActive(true);
            cameraNaturaAudioLis.enabled = true;

            cameraOspedaleAudioLis.enabled = false;
            cameraOspedale.SetActive(false);

            cameraSpazioAudioLis.enabled = false;
            cameraSpazio.SetActive(false);
        }


        //Set camera position 2
        if (camPosition == 2)
        {
            cameraSpazio.SetActive(true);
            cameraSpazioAudioLis.enabled = true;

            cameraOspedaleAudioLis.enabled = false;
            cameraOspedale.SetActive(false);

            cameraNaturaAudioLis.enabled = false;
            cameraNatura.SetActive(false);

        }

    }
}
}