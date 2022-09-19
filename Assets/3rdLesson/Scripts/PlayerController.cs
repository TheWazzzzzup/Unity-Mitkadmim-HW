using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] int _health = 5;
    [SerializeField] string _name = "Player Name";


    // Start is called before the first frame update
    void Start()
    {
        _health = PlayerPrefs.GetInt("PlayerHealth");
        _name = PlayerPrefs.GetString("PlayerName");



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("PlayerHealth", _health);
        PlayerPrefs.SetString("PlayerName", _name);
    }
}
