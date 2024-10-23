using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlyer : MonoBehaviour
{
    public Sprite[] sprites;
    private SpriteRenderer SpriteRenderer;
    private int framne;
    public void Awake()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();    
    }
    private void OnEnable()
    {
        Invoke(nameof(Animate), 0f);
    }
    private void OnDisable()
    {
        CancelInvoke();
    }
    private void Animate()
    {
        framne++;
        if(framne>=sprites.Length) framne = 0;

        if (framne >= 0 && framne < sprites.Length)
        {
        SpriteRenderer.sprite = sprites[framne];

        }
        Invoke(nameof(Animate) , 1f/gameManger.instance.gamespeed);
    }
}
