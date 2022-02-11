/*
The brik company 
made by Davide Ristorto
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suono : MonoBehaviour
{

    AudioSource audioSource;

    void Start(){
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision){
        audioSource.Play();//parte la sound track
    }
}



