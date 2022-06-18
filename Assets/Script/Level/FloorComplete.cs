using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class FloorComplete : MonoBehaviour
{
    public GameObject fadeOut;
    public GameObject completePanel;
    public GameObject thePlayer;
    public GameObject floorTimer;

    void OnTriggerEnter(Collider other)
    {
        floorTimer.SetActive(false);
        StartCoroutine(CompletedFloor());
        thePlayer.GetComponent<FirstPersonController>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;        
    }

    IEnumerator CompletedFloor()
    {
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        completePanel.SetActive(true);
        yield return new WaitForSeconds(15);
        GlobalScore.scoreValue = 0;
        GlobalComplete.EnemyCount = 0;
        GlobalComplete.LootCount = 0;
        GlobalComplete.nextFloor += 1;
        SceneManager.LoadScene(GlobalComplete.nextFloor);
    }
}
