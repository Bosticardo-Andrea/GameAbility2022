/*
The brik company 
made by Bosticardo Andrea
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attach : MonoBehaviour
{
    // Start is called before the first frame update
    public BoxCollider lego,lego1;
    private Vector3 clego,clego1;
    public GameObject lg,lg1;
    void Start()
    {
        clego = lego.size*100;
        clego1 = lego1.size*100;
        Debug.Log(clego + "" + clego1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
