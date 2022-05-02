using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SnapToSurface : MonoBehaviour
{ 
    private enum SnapType
    {
        Up,
        Down,
        Left,
        Right,
        Forward,
        Backward
    }
    [SerializeField]
    private SnapType snapType = SnapType.Down;
    public Vector3 offset;
    public bool getCollider;

    private void Update()
    {
        switch (snapType)
        {
            case SnapType.Up:
                Snapping(Vector3.up);
                break;
            case SnapType.Down:
                Snapping(Vector3.down);
                break;
            case SnapType.Left:
                Snapping(Vector3.left);
                break;
            case SnapType.Right:
                Snapping(Vector3.right);
                break;
            case SnapType.Forward:
                Snapping(Vector3.forward);
                break;
            case SnapType.Backward:
                Snapping(Vector3.back);
                break;
        }
    }

    private void Snapping(Vector3 snapDirection)
    {
        Ray ray = new Ray(transform.position, snapDirection);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "Snap Target")
            {
                transform.position = hit.point + offset;
                if (getCollider)
                {
                    Debug.Log(hit.collider);
                }
            }
        }
    }
}
