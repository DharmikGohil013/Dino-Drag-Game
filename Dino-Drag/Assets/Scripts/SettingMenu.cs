using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingMenu : MonoBehaviour
{
    public GameObject Canvasshow;
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
    }
}
