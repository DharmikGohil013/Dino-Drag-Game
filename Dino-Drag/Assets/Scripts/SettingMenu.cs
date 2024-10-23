using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingMenu : MonoBehaviour
{
    public GameObject Canvasshow;
    public GameObject Canvasshow2;
    private void Start()
    {
        Canvasshow.SetActive(false);
    }
    public void showsettingmenu()
    { 
        Canvasshow.SetActive(true);
    }
    public void showfrontpage()
    {
        Canvasshow.SetActive(false);
        Canvasshow2.SetActive(true);
    }
    
}
