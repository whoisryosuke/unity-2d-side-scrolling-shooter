using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController2D controller;

    public float horizontalMove;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
    }

    private void FixedUpdate()
    {
        Debug.Log("Moving " + horizontalMove * Time.fixedDeltaTime);
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }
}
