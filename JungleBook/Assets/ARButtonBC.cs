using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARButtonBC : MonoBehaviour, IVirtualButtonEventHandler
{

    // AR Button
    public GameObject vbButton;


    public GameObject presshere;
    public GameObject presshereplane;
    public GameObject auther;
    public GameObject review;
    public GameObject quad;
    public GameObject backdrop;




    // Start is called before the first frame update
    void Start()
    {
        // Find AR Button
        vbButton = GameObject.Find("VirtualButton");
        vbButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        // find the game objects
        presshere = GameObject.Find("PressHereText");
        auther = GameObject.Find("AuthurPages");
        presshereplane = GameObject.Find("HoldHerePlane");
        review = GameObject.Find("Review");
        quad = GameObject.Find("Quad");
        backdrop = GameObject.Find("BCBD");

        quad.SetActive(false);
        backdrop.SetActive(false);
    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        presshere.SetActive(false);
        auther.SetActive(false);
        presshereplane.SetActive(false);

        quad.SetActive(true);
        review.SetActive(true);
        backdrop.SetActive(true);

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        presshere.SetActive(true);
        auther.SetActive(true);
        presshereplane.SetActive(true);

        review.SetActive(false);
        quad.SetActive(false);
        backdrop.SetActive(false);

    }


    // Update is called once per frame
    void Update()
    {
        
    }

    
}
