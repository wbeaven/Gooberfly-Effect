using UnityEngine;

public class Port : MonoBehaviour
{
    [HideInInspector]
    public GameObject portedObject;

    public MatchEntity _ownerMatchEntity;

    private void OnTriggerEnter(Collider other)
    {
        if (portedObject == null && other.gameObject.TryGetComponent(out MovablePair CollidedMoveable))
        {
            _ownerMatchEntity.PairObjectInteraction(IsEnter:true, CollidedMoveable);
            portedObject = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (portedObject == other.gameObject && other.gameObject.TryGetComponent(out MovablePair CollidedMoveable))
        {
            _ownerMatchEntity.PairObjectInteraction(IsEnter:false, CollidedMoveable);
            portedObject = null;
        }
    }
}
