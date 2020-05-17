using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownSpazio : MonoBehaviour {

    public GameObject left;
    public GameObject right;
    public GameObject leftLight;
    public GameObject rightLight;
    public GameObject player;
    public Transform parent;

    void Update () {
        if (Input.GetKeyDown (KeyCode.Mouse1) || SCL_PositionalControllerInputDirections.direzione == "left") {
            spawnRight ();
            SCL_PositionalControllerInputDirections.direzione = "central";
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) || SCL_PositionalControllerInputDirections.direzione == "right")
        {
            spawnLeft();
            SCL_PositionalControllerInputDirections.direzione = "central";
        }
    }

    void spawnLeft () {

        Vector3 playerPos = new Vector3 (player.transform.position.x, player.transform.position.y-2, player.transform.position.z - 4);
        Vector3 playerPos2 = new Vector3 (player.transform.position.x, player.transform.position.y-2, player.transform.position.z - 6);

        Vector3 playerDirection = player.transform.forward;

        Quaternion playerRotation = player.transform.rotation;
        float spawnDistance = 3;

        Vector3 spawnPos = playerPos + playerDirection * spawnDistance;
        Vector3 spawnPos2 = playerPos2 + playerDirection * spawnDistance;
        Instantiate (left, spawnPos, playerRotation, parent);
        Instantiate (leftLight, spawnPos2, playerRotation, parent);

    }

    void spawnRight () {
        Vector3 playerPos = new Vector3 (player.transform.position.x, player.transform.position.y + 3, player.transform.position.z + 4);
        Vector3 playerPos2 = new Vector3 (player.transform.position.x, player.transform.position.y + 3, player.transform.position.z + 6);

        Vector3 playerDirection = player.transform.forward;
        Quaternion playerRotation = player.transform.rotation;
        float spawnDistance = 6;

        Vector3 spawnPos = playerPos + playerDirection * spawnDistance;
        Vector3 spawnPos2 = playerPos2 + playerDirection * spawnDistance;

        Instantiate (right, spawnPos, playerRotation, parent);
        Instantiate (rightLight, spawnPos, playerRotation, parent);

    }

}