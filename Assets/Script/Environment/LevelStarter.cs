using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    // Ba�larken 3ten geriye saymas�
    // Ses sistemlerimi ve Objeler
    public GameObject coutDown3;
    public GameObject coutDown2;
    public GameObject coutDown1;
    public GameObject coutDownGO;
    public GameObject fadeIn ;
    public AudioSource readyFX ;
    public AudioSource goFX ;

    void Start()
    {
        StartCoroutine(CountSequence()); // fonksiyonumu ba�lat
    } 
    // Sgeri say�mlar ve arka arkaya gelmesi
    IEnumerator CountSequence() {
        yield return new WaitForSeconds(1.5f);
        coutDown3.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1);
        coutDown2.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1);
        coutDown1.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1);
        coutDownGO.SetActive(true);
        goFX.Play();
        PlayerMove.canMove = true    ;


    }
}
