using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCanvasAfterDelay : MonoBehaviour
{
    public GameObject CanvasShoow;
    public GameObject CanvasShoow2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowcanvaswithDelay());

    }
    IEnumerator ShowcanvaswithDelay()
    {
        CanvasShoow.SetActive(false);
        CanvasShoow2.SetActive(false);

        yield return new WaitForSeconds(2f);
       
        CanvasShoow.SetActive(true);
        yield return new WaitForSeconds(1f);

        CanvasShoow2.SetActive(true);

        yield return new WaitForSeconds(5f);
        CanvasShoow2.SetActive(false);

        yield return new WaitForSeconds(1f);
        CanvasShoow.SetActive(false);
      
    }
}
