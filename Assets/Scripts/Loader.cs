using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loader : MonoBehaviour
{
    //PANELES EN ORDEN
    public GameObject VinilScreen;
    public GameObject CrappyScreen;
    public GameObject panel_generos;
    public GameObject panel_inicial;

    public float delayBeforeLoading = 3f;
    public float delayBeforeLoading2 = 9f;

    private float timeElapsed;

    private void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > delayBeforeLoading)
        {
            CrappyScreen.SetActive(true);
            VinilScreen.SetActive(false);
        }

        if (timeElapsed > delayBeforeLoading2) {
            CrappyScreen.SetActive(false);
        }
    }

    public void Start()
    {
        VinilScreen.SetActive(true);
        CrappyScreen.SetActive(false);
    }

    public void panelcambiogeneros()
    {
        panel_generos.SetActive(true);
    }

    public void regresoalpanel()
    {
        panel_generos.SetActive(false);
    }
}
