using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen02 : MonoBehaviour
{
    public GameObject theDoor;
    public AudioSource DoorFX;

    void OnTriggerEnter(Collider other)
    {
        DoorFX.Play();
        theDoor.GetComponent<Animator>().Play("Door2Open");
        StartCoroutine(CloseDoor());
        this.GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(5);
        theDoor.GetComponent<Animator>().Play("Door2Close");
        DoorFX.Play();
        this.GetComponent<BoxCollider>().enabled = true; 
    }
}
