using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour
{
    // Cuando hay un Collider
    private void OnMouseDown()
    {
        SceneManager.LoadScene("JuegoDino");
    }
}
