using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeraCanos : MonoBehaviour
{

    public GameObject cano;
    public float altura;
    public float intervaloGeracao;
    private float contador = 0f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject novoCano = Instantiate(cano);
        
        // Cria um prefab de cano numa altura aleatória
        novoCano.transform.position = transform.position + new Vector3(0, Random.Range(-altura, altura), 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Realiza a lógica de geração de canos
        if(contador > intervaloGeracao){
            GameObject novoCano = Instantiate(cano);

            // Cria um prefab de cano numa altura aleatória
            novoCano.transform.position = transform.position + new Vector3(0, Random.Range(-altura, altura), 0);

            //Destrói o cano construido depois de 10 segundos
            Destroy(novoCano, 10f);
            contador = 0;
        }

        contador += Time.deltaTime;
    }
}
