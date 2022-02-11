/*
The brik company 
by Bosticardo Andrea
made by Tommaso Olivero
*/
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartMenu(){//carica le scene in base al bottono premuto
        SceneManager.LoadScene(0);
    }


    public void loadGame(){
        SceneManager.LoadScene(1);
    }

    public void Istruction(){
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
