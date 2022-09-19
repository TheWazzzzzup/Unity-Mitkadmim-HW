using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class PlayerData
{
    public int hp;
    public int xp;
    public string name;
}

public class Json : MonoBehaviour
{
    string json;

    // Start is called before the first frame update
    void Start()
    {
        PlayerData Wazzzzzup = new PlayerData();
        Wazzzzzup.hp = 100;
        Wazzzzzup.xp = 256;
        Wazzzzzup.name = "Wazzzzzup";

        json = JsonUtility.ToJson(Wazzzzzup);
        Debug.Log(json);
    }
}
