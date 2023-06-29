using System;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class Sound : MonoBehaviour
{

    public AudioSource audioSource;

    private void OnCollisionEnter(Collision collision)
    {

        
        audioSource.Play();
        
    }
}