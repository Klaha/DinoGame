using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorObstaculos : MonoBehaviour
{
    // Al setear una variable como public, podemos verla visiblemente en el inspector.
    // De esta manera, la asignación se hace desde el inspector.
    // public GameObject prefabCactus;
    public GameObject[] prefabCactus;

    // Start is called before the first frame update
    void Start()
    {
        Generar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Generar()
    {
        Obstaculo.VelocidadExtra += 0.02f;
        int seleccionado = Random.Range(0, 2);
        float tiempoAleatorio = Random.Range(1.5f, 3f);

        Instantiate(prefabCactus[seleccionado]);
        Invoke("Generar", tiempoAleatorio);
    }
}
