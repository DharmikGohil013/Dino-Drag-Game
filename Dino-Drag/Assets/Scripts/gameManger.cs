using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManger : MonoBehaviour
{
   public static gameManger instance 
    { 
        get; 
        private set; 
    }
    public float initialgamespeed = 5f;
    public float Gamespeedincrece = 0.1f;

    public float gamespeed { get; private set; }
    private void Awake()
    {
        if (instance == null)
        {
           DestroyImmediate(gameObject);
        }
        else
        {
            instance=this;
        }
    }
    private void OnDestroy()
    {
        if (instance != null) {
            instance = null;
        }
    }
    private void Start()
    {
        NewGame();
    }
    private void NewGame()
    {
        gamespeed = initialgamespeed;
    }
    private void upadte()
    {
        gamespeed = gamespeed + Gamespeedincrece * Time.deltaTime;
    }

}
