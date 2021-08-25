using UnityEngine;

[CreateAssetMenu (fileName = "New Counter", menuName = "Counters")]
public class Counter_Tracker : ScriptableObject
{
    public int Num;

    private void OnEnable()
    {
        Num = 0; // If i understand this correctly, when this is enabled, the counter starts at 0
    }

    public void IncreaseCounter()
    {
        Num++; // In this method, everytime an object has been interacted, it adds the counter so long as the AddToCounter is called... i think
        Debug.Log("Adding to the counter!");
    }
}
