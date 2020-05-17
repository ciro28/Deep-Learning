using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreaOggetti : MonoBehaviour {
    SCL_PositionalControllerInputDirections controllerInput;
    public int count=0;
    Vector3 vec = new Vector3(0, 0, 0);
    public Vector3 a,b,c;
    public Boolean stop = false;


    void Start()
    {
        controllerInput = gameObject.GetComponent<SCL_PositionalControllerInputDirections>();

    }

    void Update()

    {
        if (controllerInput.GetPositionValue() != vec && transform.position != controllerInput.GetPositionValue())
        {
            if (count == 68)
            {
                count = 0;
                stop = false;
            }

            transform.position = controllerInput.GetPositionValue();
            count++;
            if (count == 40)
            {
                a = transform.position;
            }
            if (count == 43)
            {
                b = transform.position;
            }
            if (count == 52)
            {
                c = transform.position;
            }

        }


    }

}