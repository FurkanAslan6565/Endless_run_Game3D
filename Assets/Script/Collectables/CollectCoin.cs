using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    // Altýn çarpma sesi + ekleme
    public AudioSource coinFX ;
    void OnTriggerEnter(Collider other) 
    {
        coinFX.Play();
        CollactableControl.coinCount += 1 ; 
        this.gameObject.SetActive(false);
    }
  
}
