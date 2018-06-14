using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour {

    public Color altColor = Color.red;
    public Renderer rend;

    // Use this for initialization
    void Start () {
        //Get the renderer of the object so we can access the color
        rend = GetComponent<Renderer>();
        //Set the initial color (0f,0f,0f,0f)
       // rend.material.color = altColor;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "End")
        {
            //Alter the color          
            altColor.g += 0.5f;
            //Assign the changed color to the material.
            rend.material.color = altColor;
        }
    }
}
