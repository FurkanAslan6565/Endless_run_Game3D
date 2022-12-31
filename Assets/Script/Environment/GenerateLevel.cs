using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    //  Alan olu�turuyoruz ve sonsuz bir alan yap�yoruz 
    public GameObject[] section ;  
    public int zPos = 50 ;  
    public bool creatingSection = false ;  
    public int secNum ;


    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true ; 
            StartCoroutine(GenerateSection()); 
        }
    }
    // yineleyici 
    IEnumerator GenerateSection() {
        secNum = Random.Range(0,4); // yapt���m 4 sectiondan random olarak sec 
        // Klon olu�turuyom
        Instantiate(section[secNum],new Vector3 (0,0, zPos),Quaternion.identity); // rotasyon yok
        zPos +=50 ; 
        yield return new WaitForSeconds(2); // Her 2 saniyede random sec ve bunlar� bir sonraki sectiona ekle 
        creatingSection = false ; 
    }
}
