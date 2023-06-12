using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverPanel : MonoBehaviour
{
    public bool isOver = false; //cuando haga las clases poner protected.

    private void OnMouseEnter()
    {
        isOver = true;
        Debug.Log("entro");
    }

    private void OnMouseExit()
    {
        isOver = false;
        Debug.Log("salio");
    }
}
