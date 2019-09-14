using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Music : MonoBehaviour
{
    // Start is called before the first frame update


    public AudioClip aClip;
    public AudioSource aSource;

    void Start()
    {
        aSource.clip = aClip;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
            aSource.Play();

        if(Input.GetKeyDown(KeyCode.S))
            aSource.Stop();
    }
}
