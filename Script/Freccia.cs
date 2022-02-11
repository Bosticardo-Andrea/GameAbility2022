/*
The brik company 
made by Olivero Tommaso
*/
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Freccia : MonoBehaviour
{
    public static int scene=2;
    public void Continue(){
        scene+=1;//cambia la scena se si preme il pulsante (con il mouse) --> primo step interazione senza leap
        SceneManager.LoadScene(scene);
    }
}

