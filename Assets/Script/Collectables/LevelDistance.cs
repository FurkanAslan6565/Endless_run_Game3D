using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelDistance : MonoBehaviour
{
    // Ne kadar yol gitti?im 
    public GameObject disDisplay ; 
    public GameObject disEndDisplay ; 
    public int disRun = 1; 
    public bool addingDis = false ; 
    public float disDelay = 0.35f ;  

    void Update()
    {
        if(addingDis == false){
            addingDis = true; 
            StartCoroutine(AddingDis()); 
        }
    }
    IEnumerator AddingDis(){
        disRun += 1; 
        disDisplay.GetComponent<Text>().text = "" + disRun ; 
        disEndDisplay.GetComponent<Text>().text = "" + disRun ; 
        yield return new WaitForSeconds(disDelay);
        addingDis = false ;  

    }
}


