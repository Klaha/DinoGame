using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    public Text contadorDisplay;

    public static float contador;

    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        contadorDisplay.text = contador.ToString("00000");
        contador += Time.deltaTime * 100;
    }
}
