using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Init : MonoBehaviour
{
    public Button startButton;
    public AudioSource source;
    public GameObject angryDino;

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
        angryDino.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("JuegoDino");
    }

    
}
