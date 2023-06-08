using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DradAndDrop : MonoBehaviour
{
    public bool isClicked;
    private Camera cam;
    private Vector3 dragOffset;
    private GameObject panel;

    private void Awake()
    {
        cam = Camera.main;
        panel = GameObject.FindGameObjectWithTag("Panel");
    }

    private void OnMouseDown()
    {
        dragOffset = transform.position - GetMousePos();
    }

    private void OnMouseUp()
    {
        
    }

    private void OnMouseDrag()
    {
        transform.position = GetMousePos() + dragOffset;
    }

    Vector3 GetMousePos()
    {
        var mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
}
