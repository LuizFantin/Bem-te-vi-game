using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontos : MonoBehaviour
{
    public ControladorJogo controlador;

    void Start(){
        controlador = FindObjectOfType<ControladorJogo>();
    }

    void OnTriggerEnter2D(Collider2D colisor) {
        controlador.pontuacao++; // Soma um ponto a cada cano ultrapassado
        controlador.contadorNoite++; // Acumula pontos para definir se o jogo fica de noite
        controlador.textoPontuacao.text = controlador.pontuacao.ToString(); // Mostra a pontuação atual na tela
    }
}
