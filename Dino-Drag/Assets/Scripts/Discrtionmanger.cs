using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Discrtionmanger : MonoBehaviour
{
    public GameObject firstcanvas;
    public GameObject discrtioncanvas2;
    public GameObject discrtioncanvas;
    public void showfirtcanvas()
    {
        firstcanvas.SetActive(true);
        discrtioncanvas.SetActive(false);
        
    }
    public void showsecond()
    {
        firstcanvas.SetActive(false );
        discrtioncanvas.SetActive(true);
        
    }
    public void showsecond1()
    {
        firstcanvas.SetActive(true);
        discrtioncanvas2.SetActive(false);
    }
}

