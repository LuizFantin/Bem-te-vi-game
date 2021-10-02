using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControladorJogo : MonoBehaviour
{
    public int pontuacao;
    public GameObject fundoNoite;
    public GeraCanos geraCanos;
    public Text textoPontuacao;
    public Text textoRecorde;
    public int limiteNoite;
    public int contadorNoite = 0;


    public AudioSource grito;

    private bool noite = false;
    
    public void RestartGame(){
        SceneManager.LoadScene("Principal"); // carrega novamente a jogo
    }
    
    public void GoToMenu(){
        SceneManager.LoadScene(0); // Vai para o Menu
    }

    void Start() {
        Time.timeScale = 1; // despausa o jogo
        textoRecorde.text = "Recorde: " + PlayerPrefs.GetInt("Recorde");
        geraCanos = FindObjectOfType<GeraCanos>();
    }

    void Update() {
        // Realiza o teste se está na hora de alterar entre dia e noite
        if(contadorNoite == limiteNoite){
            noite = !noite;
            contadorNoite = 0;
            fundoNoite.SetActive(noite);
            grito.Play();
        }

        // Atualiza o recorde se a pontuação atual for maior que o recorde atual
        if(pontuacao > PlayerPrefs.GetInt("Recorde")){
            PlayerPrefs.SetInt("Recorde", pontuacao);
        }
        textoRecorde.text = "Recorde: " + PlayerPrefs.GetInt("Recorde");

        // Bloco de condicionais para adicionar dificuldade no jogo com o passar dos pontos
        if(pontuacao >= 5 && pontuacao <= 9){
            geraCanos.intervaloGeracao = 3.5f;
        }

        if(pontuacao > 9 && pontuacao <= 19){
            geraCanos.intervaloGeracao = 3f;
        }

        if(pontuacao > 19 && pontuacao <= 29){
            geraCanos.intervaloGeracao = 2f;
        }

        if(pontuacao > 29 && pontuacao <= 39){
            geraCanos.intervaloGeracao = 1.5f;
        }

        if(pontuacao > 39){
            geraCanos.intervaloGeracao = 1.2f;
        }
    }
}
