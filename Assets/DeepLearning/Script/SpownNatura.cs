using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownNatura : MonoBehaviour {

    public GameObject left;
    public GameObject leftLight;
    public GameObject rightLight;
    public GameObject right;
    public GameObject player;
    public Transform parent;

    void Update () {
        if (Input.GetKeyDown (KeyCode.Mouse0)) {
            spawnLeft ();

        }
        if (Input.GetKeyDown (KeyCode.Mouse1)) {
            spawnRight ();
        }
    }

    void spawnLeft () {
        /* (player.transform.position.z <= 20) {
             //  Instantiate (left, new Vector3 (player.transform.position.x - 2, player.transform.position.y, player.transform.position.z ), Quaternion.identity);
             Instantiate (left, new Vector3 (player.transform.position.x - 3, player.transform.position.y, player.transform.position.z - 2), new Quaternion (), parent);

         }*/
        Vector3 playerPos = new Vector3 (player.transform.position.x + 4, player.transform.position.y - 5, player.transform.position.z + 4);
        Vector3 playerPos2 = new Vector3 (player.transform.position.x + 7, player.transform.position.y - 4, player.transform.position.z + 4);

        Vector3 playerDirection = player.transform.forward;

        Quaternion playerRotation = player.transform.rotation;
        float spawnDistance = 3;

        Vector3 spawnPos = playerPos + playerDirection * spawnDistance;
        Vector3 spawnPos2 = playerPos2 + playerDirection * spawnDistance;
        Instantiate (left, spawnPos, playerRotation, parent);
        Instantiate (leftLight, spawnPos2, playerRotation, parent);

    }

    void spawnRight () {
        Vector3 playerPos = new Vector3 (player.transform.position.x, player.transform.position.y - 5, player.transform.position.z - 9);
        Vector3 playerPos2 = new Vector3 (player.transform.position.x+2, player.transform.position.y - 4, player.transform.position.z - 11);

        Vector3 playerDirection = player.transform.forward;
        Quaternion playerRotation = player.transform.rotation;
        float spawnDistance = 10;

        Vector3 spawnPos = playerPos + playerDirection * spawnDistance;
        Vector3 spawnPos2 = playerPos2 + playerDirection * spawnDistance;

        Instantiate (right, spawnPos, playerRotation, parent);
        Instantiate (rightLight, spawnPos2, playerRotation, parent);

    }

}