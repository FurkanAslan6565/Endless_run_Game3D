using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    //sað sol sýnýr çizgileri 
    public static float leftSide = 29f ; 
    public static float rightSide = 36f ; 
    public static float internalLeft ;
    public static float internalRight; 

    void Update()
    {
        internalLeft = leftSide ; 
        internalRight = rightSide ; 

    }
}
