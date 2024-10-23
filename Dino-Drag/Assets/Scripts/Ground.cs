using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private MeshRenderer MeshRenderer;
    public void Awake()
    {
        MeshRenderer = GetComponent<MeshRenderer>();
    }
    public void Update()
    {
        float Speed = gameManger.instance.gamespeed /transform.localScale.x;
        MeshRenderer.material.mainTextureOffset += Vector2.right * Speed * Time.deltaTime;
    }
}
