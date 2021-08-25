using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Colour : MonoBehaviour
{
    private int clickNum;
    public Material[] materials;
    //public bool isTrueOrFalse = false; //No current function for it

    public Counter_Tracker Object; //testing purposes only

    private MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    //private void Update()
    //{
    //    int i;
    //    i = 0;
    //}

    void OnMouseDown()
    {
        meshRenderer.material = materials[clickNum];
        clickNum++;
        Object?.IncreaseCounter(); //for testing purposes only

        //isTrueOrFalse = true; //This enables the bool variable to be changed to true only once

        if (clickNum >= materials.Length) // Length may have to do with what the amount of the array is
        {
            clickNum = 0;
            Object?.IncreaseCounter();
            Debug.Log("Not sure what happens here but it happens");            
        }

        Debug.Log("The Mouse button has been pressed and a thing has happened");
    }
}
