using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DradAndDrop : MonoBehaviour
{
    public bool isClicked;

    private void OnMouseDrag()
    {
        transform.position = GetMousePos();
    }

    Vector3 GetMousePos()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }

    //video: https://www.google.com/search?q=how+to+make+a+drag+and+drop+in+unity+2d&rlz=1C1GCEU_enAR828AR828&oq=how+to+make+a+drag+and+drop+in+unity+2d&aqs=chrome..69i57j33i22i29i30l2.100799j0j9&sourceid=chrome&ie=UTF-8#fpstate=ive&vld=cid:7a5114e6,vid:Tv82HIvKcZQ
}
