using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControladorJogo : MonoBehaviour
{
    public int pontuacao;
    public Text textoPontuacao;
    
    public void RestartGame(){
        SceneManager.LoadScene(0); // carrega novamente a jogo
    }

    void Start() {
        Time.timeScale = 1; // despausa o jogo
    }
}
