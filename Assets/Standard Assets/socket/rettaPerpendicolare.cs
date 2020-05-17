using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class rettaPerpendicolare : MonoBehaviour
{
    GameObject vx;
    Vector3[] newVertices;
    Vector2[] newUV;
    CreaOggetti c;
    int[] newTriangles;

    // Start is called before the first frame update
    void Start()
    {
        vx = Resources.Load<GameObject>("punto");
        c = gameObject.GetComponent<CreaOggetti>();

    }

    // Update is called once per frame
    void Update()
    {

        if (!c.stop && c.count==68)
        {
            c.stop = true;

            Instantiate(vx, c.a, Quaternion.identity);//, gameObject.transform);
            Instantiate(vx, c.b, Quaternion.identity);//, gameObject.transform);
            Instantiate(vx, c.c, Quaternion.identity);//, gameObject.transform);

            newVertices = new Vector3[] { c.a, c.b, c.c };
            newTriangles = new int[] { 0, 2, 1 };
            Mesh mesh = new Mesh();
            mesh.vertices = newVertices;
            //mesh.uv = newUV;
            mesh.triangles = newTriangles;
            mesh.RecalculateNormals();
            GetComponent<MeshFilter>().mesh = mesh;
            Debug.Log("mesh.normals" + mesh.normals[0].x + " " + mesh.normals[0].y + mesh.normals[0].z);
            

            GameObject raggioVisivo = new GameObject();
            raggioVisivo.tag = "normal";
           // raggioVisivo.transform.position = (pos1+pos2)/2;
            raggioVisivo.AddComponent<LineRenderer>();
            LineRenderer lr = raggioVisivo.GetComponent<LineRenderer>();
           // lr.material = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
            lr.startColor=Color.cyan;
            lr.endColor= Color.yellow;  // questa non funziona
            lr.startWidth=2.1f;
            lr.endWidth=2.9f;
            lr.SetPosition(0, (c.a + c.b) / 2);
            lr.SetPosition(1, mesh.normals[0]*-200 + transform.position);
            Debug.Log("Sono setPosition 1" + mesh.normals[0] * -200 + transform.position);

            float meshX = mesh.normals[0].x * -200;

            Debug.Log("Sono meshX " + meshX);
            
            if (meshX >= -20 && meshX  <= 20)
            {
                // central
                SCL_PositionalControllerInputDirections.direzione = "central";
            } else
            {
                if (meshX > 20)
                {
                    // left
                    SCL_PositionalControllerInputDirections.direzione = "left";
                } else
                {
                    if(meshX < -20)
                    {
                        // right
                        SCL_PositionalControllerInputDirections.direzione = "right";
                    }
                }
            }

            Debug.Log("direzione " + SCL_PositionalControllerInputDirections.direzione);
        }
    }
}
