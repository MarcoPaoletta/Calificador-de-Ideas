using UnityEngine;
using System.IO; 
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveManager
{
    public static void SaveData(Idea idea)
    {
        GameData gameData = new GameData(idea);
        string dataPath = Application.persistentDataPath + "/data.txt";
        FileStream fileStream = new FileStream(dataPath, FileMode.Create);
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        binaryFormatter.Serialize(fileStream, gameData);
        fileStream.Close();
    }

    public static GameData LoadData()
    {
        string dataPath = Application.persistentDataPath + "/data.txt";

        if(File.Exists(dataPath))
        {
            FileStream fileStream = new FileStream(dataPath, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            GameData gameData = (GameData) binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            return gameData;
        }
        else
        {
            return null;
        }
    }
}
