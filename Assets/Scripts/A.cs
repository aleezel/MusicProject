using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class A : MonoBehaviour
{
    public Vector2 inicio;
    public Vector2 direccion;
    public Text texto;
    public float x;
    public GameObject pivote;
    public Vector3 checkpointPivote;
    public Vector3 newPosition;
    

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.touchCount>0) {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    inicio = touch.position;
                    break;
                case TouchPhase.Moved:
                    direccion = touch.position - inicio;
                    break;
                case TouchPhase.Ended:
                    x = direccion.x;
                    switch (x) {
                        case float n when (n >= 1):
                            checkpointPivote = pivote.transform.position;
                            newPosition = checkpointPivote + new Vector3(0, 0, 5.5f);
                            pivote.transform.position = newPosition;
                            break;
                        case float n when (n <= 1):
                            checkpointPivote = pivote.transform.position;
                            newPosition = checkpointPivote + new Vector3(0, 0, -5.5f);
                            pivote.transform.position = newPosition;
                            break;
                    }
                    break;
            }
        }
    }
}
