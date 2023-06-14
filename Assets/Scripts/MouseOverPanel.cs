using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverPanel : MonoBehaviour
{
    public bool isOver = false; //cuando haga las clases poner protected.

    //private void OnMouseEnter()
    //{
    //    isOver = true;
    //    Debug.Log("entro");
    //}

    //private void OnMouseExit()
    //{
    //    isOver = false;
    //    Debug.Log("salio");
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {

        var DnD = collision.gameObject.GetComponent<DradAndDrop>();
        if(DnD)
        {
            DnD.returnToSpawn = !DnD.returnToSpawn;
        }
    }
}
