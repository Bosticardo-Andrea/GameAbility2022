/*
The brik company 
made by Bosticardo Andrea
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MuoviCursoreHome : MonoBehaviour
{
    private float xpalmo, ypalmo;
    public GameObject palmo;
    public GameObject dito;
    private float posDito;
    bool click = false;

    public GameObject bottonePlay;
    
    private float width,height;

    void Start()
    {//come per MuoviManoCH prendo la grandezza dei bottoni
        width = bottonePlay.GetComponent<RectTransform>().rect.width;
        height = bottonePlay.GetComponent<RectTransform>().rect.height;
    }
    void Update()
    {
        xpalmo = palmo.transform.position.x;//predno le coordinate del poslo (chiamato palmo per errore, in tutti gli script)
        ypalmo = palmo.transform.position.y;
        //y é stata sottratta ad un numero cosí "strano"(0.45) perché é la differenza dalla coordinata del polso a quella del puntatore, diversa per ogni schermata.
        gameObject.transform.position = new Vector3((xpalmo*100), ((ypalmo-0.45f)*150), transform.position.z);//gli assegno le nuove coordinate per poterlo spostare,x * 100 perché é rapporto alle cordinate della mano effettiva stessa cosa per y
        if(controllaCord(bottonePlay)){//controllo delle coordinate
            bottoneClick(1);
        }
    }
    bool controllaCord(GameObject bottone){
        bool ok = false;
        float x = palmo.transform.position.x;
        float y = palmo.transform.position.y;
        /*
        centro bottone - larghezza/2 == lato destro
        centro bottone + larghezza/2 == lato sinistro
        centro bottone - altezza/2 == lato alto
        centro bottone + altezza/2 == lato alto
        */
        if(x < bottone.transform.position.x+width/2 && x > bottone.transform.position.x-width/2 && y < bottone.transform.position.y+height/2 && y > bottone.transform.position.y-height/2){//controllo che il puntatore sia all'interno dell'area del bottone
            ok = true;//true == é nell'area
        }
        return ok;
    }
    /*
    viene passata su unity la prima falange a partire dal polso della mano (chiamata index a dal leap)
    si controlla se viene routata sull'asse z per verificare se é avvenuto un click
    tengo a precisare che in questa funzione é stata creata da Ristorto Davide, modificata da me Bosticardo Andrea per un corretto funzionamento 
    */
    bool isClick()//controllo che sia avvenuto in click
    {
        posDito = dito.transform.rotation.eulerAngles.z;
        if(posDito>220){
            click = true;
        }
        else{
            click = false;
        }
      return click;
    }


    private void bottoneClick(int scena){
           // controllo se avviene un click
            if(isClick()){
                SceneManager.LoadScene(scena);//cambio scena
            }
    }

}
