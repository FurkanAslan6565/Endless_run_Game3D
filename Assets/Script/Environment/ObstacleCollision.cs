using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{   // �arp��ma ile ilgili obje ve �arpt���ndaki ses

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
        // �arpma Animasyonu
        characterModel.GetComponent<Animator>().Play("Stumble Backwards");
        // Oyunu sonu 
        GameOverPanel.SetActive(true);


        // DENEME Kodlar�m 
        //levelControl.GetComponent<LevelDistance>().enabled = false ;  
        //levelControl.GetComponent<EndRunSequence>().enabled = true;
    }

}
