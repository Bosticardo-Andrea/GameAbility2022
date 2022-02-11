/*
The brik company 
made by Bosticardo Andrea
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//scrip che serve per andare avanti nelle istruzioni
public class SkipInstr1 : MonoBehaviour
{
    private float xpalmo, ypalmo;
    public GameObject palmo;
    public GameObject dito;
    private float posDito;
    bool click = false;

    public GameObject bottoneR;
    
    private float width,height;
    private int handChoise;

    void Start()
    {//come per MuoviManoCH prendo la grandezza dei bottoni
        width = bottoneR.GetComponent<RectTransform>().rect.width;
        height = bottoneR.GetComponent<RectTransform>().rect.height;
    }
    void Update()
    {//predno le coordinate del poslo (chiamato palmo per errore, in tutti gli script)
        xpalmo = palmo.transform.position.x;
        ypalmo = palmo.transform.position.y;
        //y é stata sottratta ad un numero cosí "strano"(0.29969) perché é la differenza dalla coordinata del polso a quella del puntatore, diversa per ogni schermata.
        gameObject.transform.position = new Vector3((xpalmo)*100, ((ypalmo-0.29969f)*20), transform.position.z);//gli assegno le nuove coordinate per poterlo spostare,x * 100 perché é rapporto alle cordinate della mano effettiva stessa cosa per y
        if((xpalmo)*100 > 6 &&  (((ypalmo-0.29969f)*20) < 1)){//controlle le coordinate, base alle coordinate del bottone
            bottoneClick(5);
        }
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
            //controllo che sia avvenuto in click
            if(isClick()){
                SceneManager.LoadScene(scena);//cambio scena
            }
    }

}

