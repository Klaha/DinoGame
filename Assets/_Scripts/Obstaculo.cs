using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    // Solo de un obstaculo
    float velocidadX;

    // Compartida entre todos los obstaculos.
    public static float VelocidadExtra;

    // Start is called before the first frame update
    void Start()
    {
        velocidadX = 0.10f + VelocidadExtra;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(-velocidadX, 0, 0);
    }

    // Momento cuando desaparece de la cámara el GameObject
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
