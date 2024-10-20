using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Build.Content;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private MeshRenderer MeshRenderer;
    private void Awake()
    {
        MeshRenderer = GetComponent<MeshRenderer>();    
    }
    private void Update()
    {
        float speed = gameManger.instance.gamespeed/transform.lossyScale.x;
        MeshRenderer.material.mainTextureOffset = Vector2.right * speed * Time.deltaTime;

    }
}
