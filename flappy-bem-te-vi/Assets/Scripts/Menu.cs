using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //Funcaoo utilizada para carregar determinada cena
    public void LoadScene(int indexScene) //O parametro define a cena que deve ser carregada
    {
        SceneManager.LoadScene(indexScene);
    }

    //Funcaoo utilizada para encerrar o jogo
    public void ExitScene()
    {
        Application.Quit();
    }


}
