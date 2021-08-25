using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{
    public GameObject thingToAppear; 
    void Start()
    {
        thingToAppear.SetActive(false);
        Debug.Log("Thing to appear");
    }
}
