using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] GameObject pickupSFX;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayPickupSound();
        }
    }
    private void PlayPickupSound()
    {
        GameObject sfx = Instantiate(pickupSFX, transform.position, Quaternion.identity);
        Debug.Log("Played pickup sound");
    }
}
