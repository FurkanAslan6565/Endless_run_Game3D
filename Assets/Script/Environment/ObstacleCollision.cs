using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{   // Çarpýþma ile ilgili obje ve çarptýðýndaki ses

    public GameObject thePlayer; 
    public GameObject characterModel;
    public AudioSource crashThud;
    //public GameObject levelControl;

    public GameObject GameOverPanel;

    void OnTriggerEnter(Collider other) 
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false ;
        thePlayer.GetComponent<PlayerMove>().enabled = false ;
        //Ses Efektini ekledim
        crashThud.Play();
        // Çarpma Animasyonu
        characterModel.GetComponent<Animator>().Play("Stumble Backwards");
        // Oyunu sonu 
        GameOverPanel.SetActive(true);


        // DENEME Kodlarým 
        //levelControl.GetComponent<LevelDistance>().enabled = false ;  
        //levelControl.GetComponent<EndRunSequence>().enabled = true;
    }

}
