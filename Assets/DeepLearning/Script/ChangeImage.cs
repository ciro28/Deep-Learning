using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour {

    public float actTime= 0f;

    public GameObject OspedalePulito;
    public GameObject OspedaleDegrado;
    public GameObject OspedaleHorror;

    void Start () {
      
        OspedalePulito.SetActive (true);
        OspedaleDegrado.SetActive (false);
        OspedaleHorror.SetActive (false);
    }

    // Update is called once per frame
    void Update () {
        actTime += Time.deltaTime;

        if (actTime >= 10f && actTime <= 20f) {

            //chiama funzione per cambio immagine oggetto
            newImage1 ();

        }
        if (actTime >= 20f) {

            //chiama funzione per cambio immagine oggetto
            newImage2 ();
            

        }
      
    }

    void newImage1 () {
        
        OspedalePulito.SetActive (false);
        OspedaleDegrado.SetActive (true);
        OspedaleHorror.SetActive (false);

    }
    void newImage2 () {

        OspedalePulito.SetActive (false);
        OspedaleDegrado.SetActive (false);
        OspedaleHorror.SetActive (true);
        

    }

}