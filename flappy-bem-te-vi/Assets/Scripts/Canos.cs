using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canos : MonoBehaviour
{
    public float velocidade;

    // Update is called once per frame
    void Update()
    {
        // Realiza a movimentação dos canos na horizontal para a esquerda
        transform.position += Vector3.left * velocidade * Time.deltaTime;
    }
}
