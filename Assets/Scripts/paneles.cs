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
    public GameObject panel_alternativo;
    public GameObject panel_pop;
    public GameObject panel_rockalt;
    public GameObject panel_artrock;
    public GameObject panel_rockenesp;
    public GameObject panel_rock;
    public GameObject panel_electropop;
    public GameObject panel_electronicadance;

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

    public void panelalt()
    {
        panel_alternativo.SetActive(true);
    }

    public void panelaltreg()
    {
        panel_alternativo.SetActive(false);
    }

    public void panelpop()
    {
        panel_pop.SetActive(true);
    }

    public void panelpopreg()
    {
        panel_pop.SetActive(false);
    }

    public void panelrockalt()
    {
        panel_rockalt.SetActive(true);
    }

    public void panelrockaltreg()
    {
        panel_rockalt.SetActive(false);
    }

    public void panelartrock()
    {
        panel_artrock.SetActive(true);
    }

    public void panelartrockreg()
    {
        panel_artrock.SetActive(false);
    }

    public void panelrockenesp()
    {
        panel_rockenesp.SetActive(true);
    }

    public void panelrockenespreg()
    {
        panel_rockenesp.SetActive(false);
    }

    public void panelrock()
    {
        panel_rock.SetActive(true);
    }

    public void panelrockreg()
    {
        panel_rock.SetActive(false);
    }

    public void panelelectropop()
    {
        panel_electropop.SetActive(true);
    }

    public void panelelectropopreg()
    {
        panel_electropop.SetActive(false);
    }

    public void panelelectronicadance()
    {
        panel_electronicadance.SetActive(true);
    }

    public void panelelectronicadancereg()
    {
        panel_electronicadance.SetActive(false);
    }




}
