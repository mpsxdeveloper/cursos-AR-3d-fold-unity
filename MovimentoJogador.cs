using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoJogador : MonoBehaviour
{

    public Rigidbody rb;
    public float velocidade = 1f;
    public float velocidadeRotacao = 30f;

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical") * velocidade;
        rb.velocity = transform.forward * v;
        float h = Input.GetAxis("Horizontal") * velocidadeRotacao;
        transform.Rotate(Vector3.up * h * Time.deltaTime);
    }

}