using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoBajar : MonoBehaviour
{
    public Vector3 pos;
    public Vector3 new_pos;


    void OnTriggerStay(Collider other)
    {
        //Debug.Log("gggggaq");
        if (other.tag == "cuboBajar")
        {
            Debug.Log("bajar");
            //Debug.Log(other.transform.position);
            pos = this.transform.position;
            new_pos = pos + new Vector3(0, -5, 0);
            this.transform.position = new_pos;
        }

    }
}
