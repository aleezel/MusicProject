using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento_prueba1 : MonoBehaviour
{
    public Transform pivote;
    public float smoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;


    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 bar1 = pivote.TransformPoint(new Vector3(0, 0, 0));
        transform.position = Vector3.SmoothDamp(transform.position, bar1, ref velocity, smoothTime);
    }
}
