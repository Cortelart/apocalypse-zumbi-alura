using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    private CharacterController controller;
    public float Speed;
    public float rotSpeed;
    private float rot;
    private Vector3 moveDirection;
    private Animator anim;
    public float Gravity;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
       
    }

    void Move()
    {
        if(controller.isGrounded)
        {
            if(Input.GetKey(KeyCode.W))
            {
                moveDirection = Vector3.forward * Speed;
                anim.SetInteger("Transition", 1);
            }
            if(Input.GetKeyUp(KeyCode.W))
            {
                moveDirection = Vector3.zero;
                anim.SetInteger("Transition", 0);
            }
            if(Input.GetKey(KeyCode.S))
            {
                moveDirection = Vector3.forward * - Speed;
                anim.SetInteger("Transition", 1);
            }
            if(Input.GetKeyUp(KeyCode.S))
            {
                moveDirection = Vector3.zero;
                anim.SetInteger("Transition", 0);
            }
        }

        rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0,rot, 0);

        moveDirection.y -= Gravity * Time.deltaTime;
        moveDirection = transform.TransformDirection(moveDirection);
        controller.Move(moveDirection * Time.deltaTime);
    }
}
