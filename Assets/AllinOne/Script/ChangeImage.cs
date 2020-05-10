using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour {

    public float actTime = 0f;
    public Sprite DeadBird;
    /*  Image myImageComponent;
    public Sprite myFirstImage; //Drag your first sprite here in inspector.
    public Sprite mySecondImage; //Drag your second sprite here in inspector.
 */ // Start is called before the first frame update
    void Start () {
        //     myImageComponent = GetComponent<Image> ();
       
    }

    // Update is called once per frame
    void Update () {
        actTime += Time.deltaTime;

        if (actTime >= 2f) {
            
           
            //chiama funzione per cambio immagine oggetto
            newImage ();
        
        }
    }

    void newImage () {
        //  myImageComponent.sprite = mySecondImage;
        actTime = 0f;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = DeadBird;

    }

    /* public void SetImage1 () //method to set our first image
    {
        myImageComponent.sprite = myFirstImage;
    }
*/
}