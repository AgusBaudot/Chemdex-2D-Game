using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DradAndDrop : MonoBehaviour
{
    private Camera cam;
    private Vector3 dragOffset;
    private GameObject panel;
    public MouseOverPanel mouseOverPanel;
    public Vector2 spawnPoint;
    public bool returnToSpawn = true;
    [SerializeField] bool mouseUp = false;

    private void Awake()
    {
        cam = Camera.main;
        spawnPoint = new Vector3(transform.position.x, transform.position.y);
        //panel = GameObject.FindGameObjectWithTag("Panel");
        //mouseOverPanel = panel.GetComponent<MouseOverPanel>();
    }

    private void OnMouseDown()
    {
        dragOffset = transform.position - GetMousePos();
        mouseUp = false;
    }

    private void OnMouseUp()
    {
        //if (mouseOverPanel.isOver)
        //{
        //    transform.position = spawnPoint.transform.position;
        //    //cambio su posición a spawnpoint y: detruyo si hago instanciate o desactivo si hago pooling.
        //}
        //Detectar si el mouse está sobre el panel.
        //O sea, chequear si la posición del mouse (getmousepos) está sobre el panel.
        //Para saber si está sobre el panel, llamar a (OnMouseOver) en el panel, ver si devuelve true.



        //if (returnToSpawn) Hacerlo despues
        //{
        //    Debug.Log("mouse up"); 
        //    transform.position = spawnPoint;
        //}
        mouseUp = true;
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

    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
}
