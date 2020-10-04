using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class HiScore : MonoBehaviour
{
    public Text hiScoreText;
    static float hiScoreData;

    // Start is called before the first frame update
    void Start()
    {
        // if HiScore.dat exists - load it.
        if (File.Exists(Application.persistentDataPath + "/HiScore.dat") == true)
        {
            Load();
        }
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/HiScore.dat"))
        {
            // nuevo binary formatter
            BinaryFormatter HiScoreBF = new BinaryFormatter();
            // abrir archivo
            FileStream HiScoreSF = File.Open(Application.persistentDataPath + "/HiScore.dat", FileMode.Open);
            // deserializar(?) data

            hiScoreData = (float)HiScoreBF.Deserialize(HiScoreSF) + 1;
            // cerrar archivo
            HiScoreSF.Close();

            hiScoreText.text = "Hi Score: " + hiScoreData.ToString("000000");
        }

    }

    public static void Save()
    {
        float hiScore;
        hiScore = Contador.contador;

        if(hiScoreData < Contador.contador)
        {
            // nuevo binary formatter
            BinaryFormatter HiScoreBF = new BinaryFormatter();
            // crear archivo
            FileStream HiScoreSF = File.Create(Application.persistentDataPath + "/HiScore.dat");
            // guardar datos en archivo
            HiScoreBF.Serialize(HiScoreSF, hiScore);
            // cerrar archivo
            HiScoreSF.Close();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
