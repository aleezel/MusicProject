using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Destacado : MonoBehaviour
{


    public GameObject PanelInfoSodaStereo;
    public GameObject PanelInfoRadiohead;
    public GameObject PanelInfoFoxygen;
    public GameObject PanelInfoBenee;
    public GameObject PanelInfoFTP;
    public GameObject PanelInfoStrokes;



    void OnTriggerStay(Collider other)
    {
        //Debug.Log("gggggaq");
        if (other.tag == "BENEE")
        {
            Debug.Log("Benee recibido");
            PanelInfoBenee.SetActive(true);
                       
            PanelInfoFTP.SetActive(false);
            PanelInfoRadiohead.SetActive(false);
            PanelInfoSodaStereo.SetActive(false);
            PanelInfoFoxygen.SetActive(false);
            PanelInfoStrokes.SetActive(false);
        }
        if (other.tag == "FosterThePeople")
        {
            PanelInfoFTP.SetActive(true);

            PanelInfoBenee.SetActive(false);
            PanelInfoRadiohead.SetActive(false);
            PanelInfoFoxygen.SetActive(false);
            PanelInfoStrokes.SetActive(false);
            PanelInfoSodaStereo.SetActive(false);
        }
        if (other.tag == "Radiohead")
        {
            PanelInfoRadiohead.SetActive(true);

            PanelInfoBenee.SetActive(false);
            PanelInfoFTP.SetActive(false);
            PanelInfoFoxygen.SetActive(false);
            PanelInfoStrokes.SetActive(false);
            PanelInfoSodaStereo.SetActive(false);
        }
        if (other.tag == "TheStrokes")
        {
            PanelInfoStrokes.SetActive(true);

            PanelInfoBenee.SetActive(false);
            PanelInfoFTP.SetActive(false);
            PanelInfoFoxygen.SetActive(false);
            PanelInfoRadiohead.SetActive(false);
            PanelInfoSodaStereo.SetActive(false);
        }
        if (other.tag == "SodaStereo")
        {
            PanelInfoSodaStereo.SetActive(true);

            PanelInfoBenee.SetActive(false);
            PanelInfoFTP.SetActive(false);
            PanelInfoFoxygen.SetActive(false);
            PanelInfoStrokes.SetActive(false);
            PanelInfoRadiohead.SetActive(false);
        }
        if (other.tag == "Foxygen")
        {
            PanelInfoFoxygen.SetActive(true);

            PanelInfoBenee.SetActive(false);
            PanelInfoFTP.SetActive(false);
            PanelInfoRadiohead.SetActive(false);
            PanelInfoStrokes.SetActive(false);
            PanelInfoSodaStereo.SetActive(false);
        }
        else
        {
            
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        PanelInfoBenee.SetActive(false);
        PanelInfoFTP.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
