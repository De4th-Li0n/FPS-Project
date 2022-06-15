using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour
{
    public GameObject healthDisplay;
    public static int healthValue;
    public int internalHealth;
    public GameObject HP100;
    public GameObject HP85;
    public GameObject HP75;
    public GameObject HP65;
    public GameObject HP50;
    public GameObject HP25;
    public GameObject HP10;

    void Start()
    {
        healthValue = 100;
    }

    void Update()
    {
        if(healthValue <= 0)
        {
            SceneManager.LoadScene(1);
        }
        internalHealth = healthValue;
        healthDisplay.GetComponent<Text>().text = "" + healthValue + " %";

        if(healthValue > 85){
            HP100.SetActive(true);
            HP85.SetActive(false);
            HP75.SetActive(false);
            HP65.SetActive(false);
            HP50.SetActive(false);
            HP25.SetActive(false);
            HP10.SetActive(false);
        }
        if(healthValue <= 10){
            HP100.SetActive(false);
            HP85.SetActive(false);
            HP75.SetActive(false);
            HP65.SetActive(false);
            HP50.SetActive(false);
            HP25.SetActive(false);
            HP10.SetActive(true);
        }
        if(healthValue <= 85 && healthValue > 75){
            HP100.SetActive(false);
            HP85.SetActive(true);
            HP75.SetActive(false);
            HP65.SetActive(false);
            HP50.SetActive(false);
            HP25.SetActive(false);
            HP10.SetActive(false);
        }
        if(healthValue <= 75 && healthValue > 65){
            HP100.SetActive(false);
            HP85.SetActive(false);
            HP75.SetActive(true);
            HP65.SetActive(false);
            HP50.SetActive(false);
            HP25.SetActive(false);
            HP10.SetActive(false);
        }
        if(healthValue <= 65 && healthValue > 50){
            HP100.SetActive(false);
            HP85.SetActive(false);
            HP75.SetActive(false);
            HP65.SetActive(true);
            HP50.SetActive(false);
            HP25.SetActive(false);
            HP10.SetActive(false);
        }
        if(healthValue <= 50 && healthValue > 25){
            HP100.SetActive(false);
            HP85.SetActive(false);
            HP75.SetActive(false);
            HP65.SetActive(false);
            HP50.SetActive(true);
            HP25.SetActive(false);
            HP10.SetActive(false);
        }
        if(healthValue <= 25 && healthValue > 10){
            HP100.SetActive(false);
            HP85.SetActive(false);
            HP75.SetActive(false);
            HP65.SetActive(false);
            HP50.SetActive(false);
            HP25.SetActive(true);
            HP10.SetActive(false);
        }
    }
}
