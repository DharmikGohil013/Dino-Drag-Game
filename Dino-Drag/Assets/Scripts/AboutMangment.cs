using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutMangment : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;
    private void Start()
    {
        
        canvas1.SetActive(true);
        canvas2.SetActive(false);
    }
    public void showcanvas2()
    {
        canvas1.SetActive(false);
        canvas2.SetActive(true);
    }
    public void hidecanvas2() { 
    canvas1.SetActive(true);
        canvas2.SetActive(false);
    }
}
