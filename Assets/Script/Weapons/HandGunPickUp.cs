using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunPickUp : MonoBehaviour
{
    public GameObject RealHandGun;
    public GameObject FakeHandGun;
    public AudioSource HandGunPickUpSound;

    public void OnTriggerEnter(Collider other) 
    {
        RealHandGun.SetActive(true);
        FakeHandGun.SetActive(false);
        HandGunPickUpSound.Play();
        this.GetComponent<BoxCollider>().enabled = false;
    }
}
