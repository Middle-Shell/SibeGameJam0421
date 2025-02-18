﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GayZerVisual : MonoBehaviour
{
    [SerializeField] private GameObject SelectedObject = null;

    public AudioClip audioSource;
    AudioSource audio;

    private IBoolianState stateble = null;
    private bool sound = false;


    //
    private SpriteRenderer mySpriteRenderer = null;
    //

    private void Start()
    {
        stateble = SelectedObject.GetComponent<IBoolianState>();
        //
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        audio = GetComponent<AudioSource>();
        //
    }


    void Update()
    {
        if (stateble != null)
        {
            if (stateble.State)
            {
                //
                mySpriteRenderer.enabled = true;
                if (!sound)
                {
                    audio.PlayOneShot(audioSource, 0.7F);
                    sound = true;
                }
                
                //
            }
            else
            {
                sound = false;
                mySpriteRenderer.enabled = false;
                //
            }
        }
    }
}
