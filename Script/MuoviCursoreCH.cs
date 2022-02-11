/*
The brik company 
made by Bosticardo Andrea 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MuoviCursoreCH : MonoBehaviour{
    private float xpalmo, ypalmo;
    public GameObject palmo;
    public GameObject dito;
    private float posDito;
    bool click = false;

    public GameObject bottoneR,bottoneL;
    
    private float width,height;
    public static int handChoise;
    public static int ciclo = 0;
    
    void Start()//prendo le misure del bottone, sono uguali per tutti;
    {
        width = bottoneR.GetComponent<RectTransform>().rect.width;
        height = bottoneR.GetComponent<RectTransform>().rect.height;
    }
    void Update()
    {
        if(ciclo == 0){//controllo di non ver premuto nulla
        xpalmo = palmo.transform.position.x;
        ypalmo = palmo.transform.position.y;//predno le coordinate del poslo (chiamato palmo per errore, in tutti gli script)
        //y é stata sottratta ad un numero cosí "strano"(0.29969) perché é la differenza dalla coordinata del polso a quella del puntatore.
        gameObject.transform.position = new Vector3((xpalmo)*100, ((ypalmo-0.29969f)*20), transform.position.z);//gli assegno le nuove coordinate per poterlo spostare,x * 100 perché é rapporto alle cordinate della mano effettiva stessa cosa per y
        if(xpalmo < 0 && ypalmo < 15){//in base a che parte dell schermo premo cambio scena e passo il valore
            bottoneClick(4,0);//sx
        }else if(xpalmo > 0 && ypalmo < 15){
            bottoneClick(4,1);
            }
        }
    }
    public int getMano(){//per prendere la scelta della mano
        return handChoise;
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
            click = true;//true == click avvenuto
        }
        else{
            click = false;//false == click non avvenuto
        }
      return click;
    }


    private void bottoneClick(int scena,int n){//cambio scena ed aumento il contatore, preso in una altro script, per questo non lo restituisco
            if(isClick()){
                SceneManager.LoadScene(scena);
                handChoise = n;//mano scelta in base al numero
                ciclo = 1;
            }
    }

}
