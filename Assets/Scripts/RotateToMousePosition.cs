using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMousePosition : MonoBehaviour
{
    [SerializeField] private FOV _fov;
    private void Update()
    {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0f;

        Vector3 rotateDirection = (mouseWorldPos - transform.position).normalized;
        float angle = Mathf.Atan2(rotateDirection.y, rotateDirection.x) * Mathf.Rad2Deg;
        _fov.SetLookDirection(rotateDirection);
    }
}
