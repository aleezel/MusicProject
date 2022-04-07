using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class links : MonoBehaviour
{
    
    public string url;

    public void onURL()
    {
        Application.OpenURL(url);
    }

}
