using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasd : MonoBehaviour
{


    private Rigidbody rig;
    public float speed = 10f;

    private Vector3 move;


    // Use this for initialization
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }




    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(hAxis * speed, 0, vAxis * speed);

        rig.AddForce(movement);
    }

}
