using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Plyer : MonoBehaviour
{
    private CharacterController Charchtar;
    private Vector3 Direcstion;
    public float Gravity = 9.81f * 2f;
    public float jumpFourse = 8f;
    private void Awake()
    {
        Charchtar = GetComponent<CharacterController>();
    }
    private void OnEnable()
    {
        Direcstion = Vector3.zero;
    }
    private void Update()
    {
        Direcstion += Vector3.down * Gravity * Time.deltaTime;
        if (Charchtar.isGrounded)
        {
            Direcstion = Vector3.down;
            if (Input.GetButton("Jump"))
            {
                Direcstion = Vector3.up * jumpFourse;
            }

        }
        Charchtar.Move(Direcstion * Time.deltaTime);
    }
}
