using UnityEngine;
using System.IO;
using System;

public class DataLogging : MonoBehaviour
{
    public GameManager gameManager; 
    private string date;
    private string filePath;
    void Start()
    {
        Debug.Log(Application.persistentDataPath);
        date = System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-s");
        String filename = "Miniproject_Elinor_" + date + ".csv";
        filePath = Path.Combine(Application.persistentDataPath, filename);

        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, "Date, Score\n");
        }
    }

     public void LogData()
    {
        Debug.Log(Application.persistentDataPath);
        string currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        string newEntry = $"{currentDate},{gameManager.score} \n";
        File.AppendAllText(filePath, newEntry);
    } 
}
