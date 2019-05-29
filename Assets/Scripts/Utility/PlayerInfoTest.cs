using UnityEngine;

[System.Serializable]
public class PlayerInfoTest
{
    public string name;
    public int lives;
    public float health;

    public PlayerInfoTest CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<PlayerInfoTest>(jsonString);
    }

}