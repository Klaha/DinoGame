using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dino : MonoBehaviour
{
    // Se asigna como valor el componente RigidBody2D arrastrándolo desde el inspector.
    public Rigidbody2D rb;

    public GameObject gameOver;

    public Animator anim;

    int fuerza;

    // Start is called before the first frame update
    void Start()
    {
        fuerza = 12;
        Time.timeScale = 1;
        this.enabled = false;
        Obstaculo.VelocidadExtra = 0;
        anim.StopPlayback();
    }

    // Update is called once per frame
    void Update()
    {
        // 0 = boton izquierdo
        // 1 = boton derecho
        // 2 = boton central.
        if (Input.GetMouseButtonDown(0) | Input.GetKey("space"))
        {
            rb.velocity = Vector2.up * fuerza;

            // Desactiva el Dino (GameObject) en su totalidad
            // (para evitar un doble salto mientras está en el aire)
            this.enabled = false;
            anim.StartPlayback();
        }
    }

    // Al colisionar con el piso, activa el Dino (GameObject) de nuevo.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.enabled = true;
        anim.StopPlayback();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
        gameOver.SetActive(true);

        // 0  = Pausa
        // >1 = Rapido
        // <1 = SlowMo
        Time.timeScale = 0;
        HiScore.Save();
    }
}
