/*
The brik company 
made by Bosticardo Andrea
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y != 0){//controllo che il blocco sia nelle griglia --> base per attacco dei pezzi
            if(gameObject.transform.position.y % 0.06f > 0){
                gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y*0.06f,gameObject.transform.position.z);
            }
        }
    }
}
