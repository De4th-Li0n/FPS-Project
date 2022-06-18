using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalComplete : MonoBehaviour
{
    public static int EnemyCount;
    public static int LootCount;

    public GameObject EnemyDisplay;
    public GameObject LootDisplay;

    public static int nextFloor = 4;


    void Update() 
    {
        EnemyDisplay.GetComponent<Text>().text = "" + EnemyCount;
        LootDisplay.GetComponent<Text>().text = "" + LootCount;
    }
}
