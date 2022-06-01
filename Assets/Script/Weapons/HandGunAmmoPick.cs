using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunAmmoPick : MonoBehaviour
{
    public GameObject fakeAmmoClip;
    public AudioSource ammoPickupSound;

    void OnTriggerEnter(Collider other)
    {
        fakeAmmoClip.SetActive(false);
        ammoPickupSound.Play();
        GlobalAmmo.handgunAmmo += 10;
    }
}
