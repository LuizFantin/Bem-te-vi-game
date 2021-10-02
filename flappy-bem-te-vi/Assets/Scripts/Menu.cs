using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //Função utilizada para carregar determinada cena
    public void LoadScene(int indexScene) //O parâmetro define a cena que deve ser carregada
    {
        SceneManager.LoadScene(indexScene);
    }

    //Função utilizada para encerrar o jogo
    public void ExitScene()
    {
        Application.Quit();
    }


}
