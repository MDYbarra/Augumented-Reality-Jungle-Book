using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ambientMusic : MonoBehaviour,
                                            ITrackableEventHandler
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