using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class paneles : MonoBehaviour
{
    public GameObject panel_generos;
    public GameObject panel_inicial;
    public GameObject panel_strokes;
    public GameObject panel_regreso;

    public void panelcambiogeneros()
    {
        panel_generos.SetActive(true);
    }

    public void regresoalpanel()
    {
        panel_generos.SetActive(false);
    }

    public void panelstrokes()
    {
        panel_strokes.SetActive(true);
    }

    public void regresostrokes()
    {
        panel_strokes.SetActive(false);
    }


}
