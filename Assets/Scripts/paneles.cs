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
    public GameObject panel_benee;
    public GameObject panel_sodastereo;
    public GameObject panel_radiohead;
    public GameObject panel_foxygen;
    public GameObject panel_fosterthepeople;

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

    public void panelbenee()
    {
        panel_benee.SetActive(true);
    }

    public void regresobenee()
    {
        panel_benee.SetActive(false);
    }
    public void panelsodastereo()
    {
        panel_sodastereo.SetActive(true);
    }

    public void regresosodastereo()
    {
        panel_sodastereo.SetActive(false);
    }

    public void panelradiohead()
    {
        panel_radiohead.SetActive(true);
    }

    public void regresoradiohead()
    {
        panel_radiohead.SetActive(false);
    }

    public void panelfoxygen()
    {
        panel_foxygen.SetActive(true);
    }

    public void regresofoxygen()
    {
        panel_foxygen.SetActive(false);
    }

    public void panelfosterthepeople()
    {
        panel_fosterthepeople.SetActive(true);
    }

    public void regresofosterthepeople()
    {
        panel_fosterthepeople.SetActive(false);
    }




}
