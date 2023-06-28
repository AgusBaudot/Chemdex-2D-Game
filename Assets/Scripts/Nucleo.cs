using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Nucleo : MonoBehaviour
{
    //[SerializeField] DradAndDrop DragnDropscript;
    [SerializeField] CircleCollider2D circleCollider;
    public Collider2D[] overlap;
    [SerializeField] LayerMask mask;
    public GameObject nucleo;
   
    private void Awake()
    {
        //DragnDropscript = gameObject.GetComponent<DradAndDrop>();
        circleCollider = gameObject.GetComponent<CircleCollider2D>();
        overlap = Physics2D.OverlapCircleAll(gameObject.transform.position, 0.5f);
        //mask = 7;
        //nucleo = GameObject.Find("Nucleo");
    }
    private void Update()
    {
        overlap = Physics2D.OverlapCircleAll(gameObject.transform.position, 0.5f, mask);
        if (overlap.Length > 1 && !Input.GetMouseButton(0))
        {
            Debug.Log(string.Format("Found {0} overlapping object(s)", overlap.Length - 1));
            Debug.Log("Formaste el núcleo del átomo!");
            Instantiate(nucleo, transform.position, Quaternion.identity);
            foreach(Collider2D thing in overlap)
            {
                Destroy(thing.gameObject);
            }
            Destroy(gameObject);
        }
    }
}
