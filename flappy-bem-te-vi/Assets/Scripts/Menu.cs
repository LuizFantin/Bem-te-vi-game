using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //Fun��o utilizada para carregar determinada cena
    public void LoadScene(int indexScene) //O par�metro define a cena que deve ser carregada
    {
        SceneManager.LoadScene(indexScene);
    }

    //Fun��o utilizada para encerrar o jogo
    public void ExitScene()
    {
        Application.Quit();
    }


}
