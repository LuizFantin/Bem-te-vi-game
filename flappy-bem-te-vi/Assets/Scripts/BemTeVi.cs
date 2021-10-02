using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BemTeVi : MonoBehaviour
{
    public GameObject fimDeJogo;
    public float velocidade = 1f;
    private Rigidbody2D rd;
    // Start is called before the first frame update
    void Start()
    {
        rd= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Ao clicar no mouse, empurra o bem-te-vi para cima, dando o efeito de voo
        if(Input.GetMouseButtonDown(0)){
            rd.velocity = Vector2.up * velocidade;
        }
    }

    void OnCollisionEnter2D(Collision2D colisor){
        fimDeJogo.SetActive(true); //chama o fim do jogo
        Time.timeScale = 0; //pausa o jogo
    }
}
