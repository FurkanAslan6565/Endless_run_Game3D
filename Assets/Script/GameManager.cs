using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene("DesertRunLvl1");
    }

    public void RestartGame(){
        SceneManager.LoadScene("DesertRunLvl1");
    }
}

