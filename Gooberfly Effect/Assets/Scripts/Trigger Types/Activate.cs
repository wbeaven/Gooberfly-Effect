using UnityEngine;

public class Activate : MonoBehaviour
{
    public Counter_Tracker Object;

    bool run = false;

    public int TargetNumber;


    private void Update()
    {
        if (Object.Num >= TargetNumber)
        {
            run = true;
        }

        if (run)
        {
            Enable();
        }

        void Enable()
        {
            Debug.Log("You have achieved the ultimate victory, respectively speaking");
            // Current issue is that there  is no point where this can play just once, the loop needs to end
        }
    }
} 
