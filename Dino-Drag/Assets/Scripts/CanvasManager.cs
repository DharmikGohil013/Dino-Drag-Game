using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public GameObject firstcanvas;
    public GameObject secondcanvas;
    // Start is called before the first frame update
    public void showsecondcanvas()
    {
        firstcanvas.SetActive(false);
        secondcanvas.SetActive(true);
    }
    public void firstcanvasshow()
    {
        secondcanvas.SetActive(false);
        firstcanvas.SetActive(true);
    }
}
