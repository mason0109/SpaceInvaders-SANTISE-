using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem 
{
    public static void SavePlayer(PlayerStats playerStats)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + playerStats.username;
        FileStream stream = new FileStream(path, FileMode.Create);

        DataToSave data = new DataToSave(playerStats);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static void SaveLeaderboard(LeaderBoard Leaderboard)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/LeaderboardData.file";
        FileStream stream = new FileStream(path, FileMode.Create);

        LeaderboardData leaderboard = new LeaderboardData(Leaderboard);

        formatter.Serialize(stream, leaderboard);
        stream.Close();
    }

    public static DataToSave LoadPlayer(string username)
    {
        string path = Application.persistentDataPath + username;
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            DataToSave data = formatter.Deserialize(stream) as DataToSave;
            stream.Close();

            return data;
        } else 
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    } 

    public static LeaderboardData LoadLeaderboard()
    {
        string path = Application.persistentDataPath + "/LeaderboardData.file";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            LeaderboardData data = formatter.Deserialize(stream) as LeaderboardData;
            stream.Close();

            return data;
        } else 
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    } 
}
