/*
 *  Front Cover Virtual Button Controls
 *
 *      When VButton is pressed and help an Animated Walking
 *  Tiger will appear on the Frone cover plane. Along with
 *  a recorded message of Title, Auther, nice message.
 *  When VButton is released the animation and recorded
 *  message will stop and disappear until the button is
 *  pressed and held again.
 *
 *  Code Sources
 *  
 *  Audio:
 *  Unity Tutorial: Playing Audio (Music and Sound Effects)
 *  By: Bowl and Cereal
 *  Youtube: https://www.youtube.com/watch?v=egxNXuwf0_g
 *
 *  Animation / Virtual Button:
 *  How To Augmented Reality App Tutorial Virtual Buttons with
 *  Unity and Vuforia
 *  By: MatthewHallberg
 *  Youtube: https://www.youtube.com/watch?v=Fgd21lbhikU&t=648s
 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARButtonFC : MonoBehaviour, IVirtualButtonEventHandler
{

    // AR Button
    public GameObject vbButtonObject;

    // Animated Tiger
    public GameObject tiger;

    // Audio clip of title, authur, message
    public AudioSource aSourceName;
    public AudioClip frontCoverNameTitle;


    // Start is called before the first frame update
    void Start()
    {
      

        // Find AR Button
        vbButtonObject = GameObject.Find("VirtualButtonFC");
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        // Find tiger and set to false(not displying)
        tiger = GameObject.Find("Tiger");
        tiger.GetComponent<GameObject>();
        tiger.SetActive(false);

    }// End Start()


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Pressed");
        // Play recorded message
        aSourceName.Play();

        // Turn on Tiger and start Walk Animantion
        tiger.SetActive(true);
        tiger.GetComponent<Animation>().Play();

    }// End OnButtonPressed()


    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Released");
        // Record Message  stops
        aSourceName.Stop();

        // Stop tiger Animation and turn off tiger
        tiger.GetComponent<Animation>().Stop();
        tiger.SetActive(false);

    }// End OnButtonRleased()



}