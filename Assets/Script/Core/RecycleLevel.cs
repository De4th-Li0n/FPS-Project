using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecycleLevel : MonoBehaviour
{    
    public GameObject gamOver;

    void Start()
    {
        GlobalLife.lifeValue -= 1;
        if(GlobalLife.lifeValue == 0)
        {
            gamOver.SetActive(true);                 
        }
        else
        {
            SceneManager.LoadScene(2);
        }
    }
}
