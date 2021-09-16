using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControladorJogo : MonoBehaviour
{
    public int pontuacao;
    public GameObject fundoNoite;
    public Text textoPontuacao;
    public Text textoRecorde;
    public int contadorNoite = 0;
    public int limiteNoite;

    private bool noite = false;
    
    public void RestartGame(){
        SceneManager.LoadScene(0); // carrega novamente a jogo
    }

    void Start() {
        Time.timeScale = 1; // despausa o jogo
        textoRecorde.text = "Recorde: " + PlayerPrefs.GetInt("Recorde");
    }

    void Update() {
        if(contadorNoite == limiteNoite){
            noite = !noite;
            contadorNoite = 0;
            fundoNoite.SetActive(noite);
        }

        if(pontuacao > PlayerPrefs.GetInt("Recorde")){
            PlayerPrefs.SetInt("Recorde", pontuacao);
        }
        textoRecorde.text = "Recorde: " + PlayerPrefs.GetInt("Recorde");
    }
}
