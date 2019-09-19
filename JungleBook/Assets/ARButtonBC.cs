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
    public GameObject ratings;




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
        ratings = GameObject.Find("cherry");


        // Will appear on back cover unless turn to FASLE here
        quad.SetActive(false);
        backdrop.SetActive(false);
        review.SetActive(false);
        ratings.SetActive(false);
    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        // Turns off info given once detected
        presshere.SetActive(false);
        auther.SetActive(false);
        presshereplane.SetActive(false);


        // ONce button is held display reviews and video
        quad.SetActive(true);
        review.SetActive(true);
        backdrop.SetActive(true);
        ratings.SetActive(true);

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        // return to orginal display when button not held
        presshere.SetActive(true);
        auther.SetActive(true);
        presshereplane.SetActive(true);


        // Turn off reviews and video
        review.SetActive(false);
        quad.SetActive(false);
        backdrop.SetActive(false);
        ratings.SetActive(false);

    }


    // Update is called once per frame
    void Update()
    {
        
    }

    
}
