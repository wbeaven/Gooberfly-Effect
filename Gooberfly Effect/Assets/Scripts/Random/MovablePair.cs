using TMPro;
using UnityEngine;

public class MovablePair : MonoBehaviour
{
    private Camera _mainCamera;
    private float _cameraZDistance;
    private Vector3 _initialPosition;
    private bool _connected;

    private bool _isBeingDragged = false;

    private const string _portTag = "Port";
    private const float _dragResponseThreshold = 2;

    void Start()
    {
        _mainCamera = Camera.main;
        _cameraZDistance = _mainCamera.WorldToScreenPoint(transform.position).z; //Z Axis of the game object for screen view
    }

    void Update()
    {
        if (_isBeingDragged)
        {
            // Get the cursor pos relative to the object transform
            Vector3 pos = CursorOnTransform(transform.position);

            // Set hight to the surface + set drag height
            pos.y = 0;

            // Set the object's position
            transform.position = pos + new Vector3(0, 0, 0.04f);
        }

        else if (!_connected)
        {
            ResetPosition();
        }
    }

    // Find the cursor position in world space relative to the object position
    private Vector3 CursorOnTransform(Vector3 objectPosition)
    {
        //find the cursor in world space
        Vector3 CameraToCursor()
        {
            return Camera.main.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x,
                Input.mousePosition.y,
                Camera.main.nearClipPlane)) - Camera.main.transform.position;
        }

        //transform relative to cam
        Vector3 camToTrans = objectPosition - Camera.main.transform.position;

        //magic
        return Camera.main.transform.position +
            CameraToCursor() *
            (Vector3.Dot(Camera.main.transform.forward, camToTrans) / Vector3.Dot(Camera.main.transform.forward, CameraToCursor()));
    }

    void OnMouseDown()
    {
        _isBeingDragged = true;
    }

    //void OnMouseDrag()
    //{
    //    Vector3 ScreenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, _cameraZDistance); //Z Axis added to screen point
    //    Vector3 NewWorldPosition = _mainCamera.ScreenToWorldPoint(ScreenPosition); //Screen point converted to world point

    //    if (!_connected)
    //    {
    //        transform.position = NewWorldPosition;
    //    }

    //    else if (Vector3.Distance(a: transform.position, b: NewWorldPosition) > _dragResponseThreshold)
    //    {
    //        _connected = false;
    //    }
    //}

    private void OnMouseUp()
    {
        if (!_connected)
        {
            ResetPosition();
        }

        _isBeingDragged = false;
    }

    public Vector3 GetPosition()
    {
        return transform.position;
    }

    public void SetInitialPosition(Vector3 NewPosition)
    {
        _initialPosition = NewPosition;
        transform.position = _initialPosition;
    }

    private void ResetPosition()
    {
        transform.position = _initialPosition;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(_portTag))
        {
            if (other.TryGetComponent(out Port port) && (port.portedObject == gameObject || port.portedObject == null))
            {
                _connected = true;
                _isBeingDragged = false;
                transform.position = other.transform.position;
            }            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(_portTag))
        {
            _connected = false;
        }
    }
}

