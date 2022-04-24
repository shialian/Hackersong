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
        Right
    }
    [SerializeField]
    private SnapType snapType = SnapType.Down;
    public Vector3 offset;

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
        }
    }

    private void Snapping(Vector3 snapDirection)
    {
        Ray ray = new Ray(transform.position, snapDirection);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            transform.position = hit.point + offset;
        }
    }
}
