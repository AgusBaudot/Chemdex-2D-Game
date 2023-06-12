using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverPanel : MonoBehaviour
{
    public bool isOver = false; //cuando haga las clases poner protected.

    private void OnMouseOver()
    {
        isOver = true;
    }
}
