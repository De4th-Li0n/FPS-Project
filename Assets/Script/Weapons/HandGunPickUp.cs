using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandGunPickUp : MonoBehaviour
{
    public GameObject RealHandGun;
    public GameObject FakeHandGun;
    public AudioSource HandGunPickUpSound;
    public GameObject pickUpDisplay;    
    public GameObject PistolDisplay;

    public void OnTriggerEnter(Collider other) 
    {
        RealHandGun.SetActive(true);
        FakeHandGun.SetActive(false);
        HandGunPickUpSound.Play();
        GlobalAmmo.handgunAmmo += 10;        
        this.GetComponent<BoxCollider>().enabled = false;
        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<Text>().text = "Handgun";
        pickUpDisplay.SetActive(true);
        PistolDisplay.SetActive(true);

    }
}
