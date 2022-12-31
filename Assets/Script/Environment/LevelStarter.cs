using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    // Baþlarken 3ten geriye saymasý
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
        StartCoroutine(CountSequence()); // fonksiyonumu baþlat
    } 
    // Sgeri sayýmlar ve arka arkaya gelmesi
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
