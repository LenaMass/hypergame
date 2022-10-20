using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RotateLevel : MonoBehaviour
{
    public float sensitivity = 0.8f;
    private Vector3 mouse_Reference;
    private Vector3 mouse_Offset;
    private Vector3 rotation;

    private bool isRotating;
  
    void Update()
    {
        if (isRotating)
        {
            mouse_Offset = Input.mousePosition - mouse_Reference;
            rotation.y = -(mouse_Offset.x + mouse_Offset.y) * sensitivity;
            transform.Rotate(rotation);
            
            mouse_Reference = Input.mousePosition;
        } 
    }
    void onMouseDown()
    {
        Input.GetMouseButtonDown(0);
        isRotating = true;
        mouse_Reference = Input.mousePosition;
    }   
    void onMouseUp()
    {
        Input.GetMouseButtonDown(0);
        isRotating = false;
    }
}
