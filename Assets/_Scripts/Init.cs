using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Init : MonoBehaviour
{
    public Button startButton;
    public AudioSource source;

    private void Start()
    {
        startButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        StartCoroutine(InitCoroutine());
    }

    IEnumerator InitCoroutine()
    {
        source.Play();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("JuegoDino");
    }

    
}
