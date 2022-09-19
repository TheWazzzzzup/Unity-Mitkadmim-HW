using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Sword_Data", menuName = "ScriptableObjects",order = 1)]
public class SwordSO : ScriptableObject
{
    public string swordName;
    public string description;
    public int damage;
    public float price;
    public Sprite image;
}
