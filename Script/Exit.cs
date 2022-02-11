/*
The brik company 
made by Bosticardo Andrea
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){//controlla se si é premuto il tasto ESC per uscire dal programma
            Application.Quit();//esce dal programma
        }
    }
}
