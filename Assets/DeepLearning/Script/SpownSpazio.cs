using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownSpazio : MonoBehaviour {

    public GameObject left;
    public GameObject right;
    public GameObject player;
    public Transform parent;

    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame

    void Update () {
        if (Input.GetKeyDown (KeyCode.Mouse0)) {
            spawnLeft ();

        }
        if (Input.GetKeyDown (KeyCode.Mouse1)) {
            spawnRight ();
        }
    }

    void spawnLeft () {
        if (player.transform.position.z <= 20) {
            //  Instantiate (left, new Vector3 (player.transform.position.x - 2, player.transform.position.y, player.transform.position.z ), Quaternion.identity);
            Instantiate (left, new Vector3 (player.transform.position.x - 3, player.transform.position.y, player.transform.position.z-2), new Quaternion (), parent);

        }

    }

    void spawnRight () {
        if (player.transform.position.z <= 20) {
            //  Instantiate (right, new Vector3 (player.transform.position.x - 3, player.transform.position.y, player.transform.position.z), Quaternion.identity);
            Instantiate (right, new Vector3 (player.transform.position.x - 10, player.transform.position.y+5, player.transform.position.z+2), new Quaternion (), parent);
        }

        //1 sono i secondi dopo quanto appare

    }

}