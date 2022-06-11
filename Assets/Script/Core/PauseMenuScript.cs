using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseMenuScript : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;    

    public static bool GameisPause = false;
    public GameObject ThePlayer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameisPause == false)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();          
            }
        }
    }

    public void PauseGame()
    {        
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameisPause = true;
        AudioListener.volume = 0f;    
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;         
        Cursor.visible = true;
    }

    public void ResumeGame()
    {        
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameisPause = false;
        AudioListener.volume = 1f;
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;         
        Cursor.visible = false;  
    }
    public void Home(int sceneID)
    {        
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
        AudioListener.volume = 1f;
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;       
        Cursor.visible = true;
    }
    public void QuitGame()
    {        
        Time.timeScale = 1f;
        Application.Quit();
        AudioListener.volume = 1f;
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;       
        Cursor.visible = true;
    }
}
