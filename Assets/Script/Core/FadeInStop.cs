using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInStop : MonoBehaviour
{   
    public GameObject FadeIn;

    void Start()
     {
         StartCoroutine(ActivationRoutine());
     }

    IEnumerator ActivationRoutine ()
     {         
         //Turn the Game Oject back off after 1 sec.
         yield return new WaitForSeconds(1);
 
         //Game object will turn off
         FadeIn.SetActive(false);
     }
}
