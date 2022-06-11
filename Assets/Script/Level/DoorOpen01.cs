using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen01 : MonoBehaviour
{
    public GameObject theDoor;
    public AudioSource DoorFX;

    void OnTriggerEnter(Collider other)
    {
        DoorFX.Play();
        theDoor.GetComponent<Animator>().Play("DoorOpen");
        StartCoroutine(CloseDoor());
        this.GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(5);
        theDoor.GetComponent<Animator>().Play("DoorClose");
        DoorFX.Play();
        this.GetComponent<BoxCollider>().enabled = true; 
    }
}
