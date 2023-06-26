using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nucleo : MonoBehaviour
{
    [SerializeField] CircleCollider2D circleCollider;
    public Collider2D[] overlap;
    [SerializeField] LayerMask mask;

    private void Awake()
    {
        circleCollider = gameObject.GetComponent<CircleCollider2D>();
        overlap = Physics2D.OverlapCircleAll(gameObject.transform.position, 0.5f);
        mask = 7;
    }
    private void Update()
    {
        if (overlap.Length > 1)
        {
            Debug.Log(string.Format("Found {0} overlapping object(s)", overlap.Length - 1));
            Debug.Log("Formaste el núcleo del átomo!");
        }
        overlap = Physics2D.OverlapCircleAll(gameObject.transform.position, 0.5f, mask);
    }
}
