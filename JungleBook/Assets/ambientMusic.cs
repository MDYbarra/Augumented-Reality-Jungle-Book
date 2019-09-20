/*
 *  Front Cover Ambient Music Controls
 *
 *      When Front Cover image is detected. Background
 *  will play at a lower volume level as not to be played
 *  over the Title, Auther, Messeage Recording. This was
 *  the script i have looking for. FYI you can not edit the
 *  Vuforia "DefaultTrackableEventHandler.cs File. 
 *
 *  Code Source
 *
 *  Audio:
 *  Unity - How can I play audio when targets get detected
 *  By: AlessandroB
 *  URL: https://developer.vuforia.com/forum/faq/unity-how-can-i-play-audio-when-targets-get-detected
 *
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ambientMusic : MonoBehaviour, ITrackableEventHandler
{
    public AudioSource aSource;


    private TrackableBehaviour mTrackableBehaviour;

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            // Play audio when target is found
            aSource.Play();
        }
        else
        {
            // Stop audio when target is lost
            aSource.Stop();
        }
    }
}