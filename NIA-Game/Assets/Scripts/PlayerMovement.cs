using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    
    public float speed;


    void Start()
    {

    }

    void Update()
    {
        Input.GetAxisRaw("Horizontal");
    }
}
