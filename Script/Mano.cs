/*
The brik company 
by Bosticardo Andrea
made by Bosticardo Andrea
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mano : MonoBehaviour
{
    public GameObject palmo;//crea un ogetto palmo da far passare allo script della scena succeviva --> tiene la variabile in memoria, altrimenti si cancella per ogni istanza di scena

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(palmo.transform.rotation.z);
    }
}
