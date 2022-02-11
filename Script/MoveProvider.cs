/*
The brik company 
made by Bosticardo Andrea
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveProvider : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject palmod, palmos;//passo oggetti e le coordinate 
    public GameObject dx, sx;
    private float rotazionePalmod,rotazionePalmos;
    private float x,y,z;
    void Start()
    {
    }
    // Update is called once per frame
    void Update(){//si aggiorna 60 volte al secondo, controllo se si deve muovere la camera e le mani
    //si prendono le coordinate di partenza, nello spazio attuale --> del gioco, spazio da x : 0,y : 0,z : 0 
    //salva le coordinate attuali in una variabile
        x = gameObject.transform.position.x; 
        y = gameObject.transform.position.y;
        z = gameObject.transform.position.z;
        //controlla quale mano é attiva 
        if(dx.activeSelf == true){
            rotazionePalmod = palmod.transform.rotation.eulerAngles.z; //trasfortmazione in angolo di Eulero, prendere la rotazione sull asse Z del polso, unico punto a poter routare
                    if(rotazionePalmod < 20 || rotazionePalmod > 340){//controlla che sia avvenuta una rotazione sia verso sinistra che verso destra, tenendo conto del range per un soggetto con protesi
            if (palmod.transform.position.z > z + 0.05 && palmod.transform.position.z < 5){//tenendo conto spazio verifica che la mano si sia spostata nello spazio: avanti,indietro,destra,sinistra,su,giú --> anche qua si é tenuto in conto di una range
                gameObject.transform.position=new Vector3(x,0,z + 0.001f );//si sposta il provider, mani e telecamera, nello spazio
            } 
            if (palmod.transform.position.z < z - 0.1 && palmod.transform.position.z > -5){
                gameObject.transform.position=new Vector3(x,0,z - 0.001f);    
            } 
            if (palmod.transform.position.x < x - 0.1 && palmod.transform.position.x > -4){
                gameObject.transform.position=new Vector3(x - 0.001f,0,z);
                        
            }
            if (palmod.transform.position.x > x + 0.1 && palmod.transform.position.x < 5){
                gameObject.transform.position=new Vector3(x + 0.001f,0,z);
            }
            if (palmod.transform.position.y > y+0.3 && palmod.transform.position.y < 0.5){
                   gameObject.transform.position=new Vector3(x,y+0.001f,z);         
                }
            if (palmod.transform.position.y < y+0.2 && palmod.transform.position.y > 0){
                   gameObject.transform.position=new Vector3(x,y-0.001f,z);          
             }
        }
        }else if(sx.activeSelf == true){//ripeto tutti i controlli per la mano sinistra
            rotazionePalmos = palmos.transform.rotation.eulerAngles.z;
            if(rotazionePalmos < 20 || rotazionePalmos > 340){
                if (palmos.transform.position.z > z + 0.05 && palmos.transform.position.z < 5){
                    gameObject.transform.position=new Vector3(x,0,z + 0.001f );
                } 
                if (palmos.transform.position.z < z - 0.1 && palmos.transform.position.z > -5){
                    gameObject.transform.position=new Vector3(x,0,z - 0.001f);    
                } 
                if (palmos.transform.position.x < x - 0.1 && palmos.transform.position.x > -4){
                    gameObject.transform.position=new Vector3(x - 0.001f,0,z);
                            
                }
                if (palmos.transform.position.x > x + 0.1 && palmos.transform.position.x < 5){
                    gameObject.transform.position=new Vector3(x + 0.001f,0,z);
                }
                if (palmos.transform.position.y < y  && palmos.transform.position.y > 0.1){
                    gameObject.transform.position=new Vector3(x,y+0.001f,z);
                            
                }
                if (palmos.transform.position.y > y && palmos.transform.position.y < 1){
                    gameObject.transform.position=new Vector3(x,y+0.001f,z);
                            
                }
            }
        }
    }
}
