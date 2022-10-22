using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 direction; 
    public int Vida;

    private CharacterController controller;
    public float Speed;
    
    private Vector3 moveDirection;
    private Animator anim;
    
    void Awake()
    {
        transform.tag = "Player";
    }
    
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        transform.tag = "Player";
    }

    
    void Update()
    {
        
        float eixoX = Input.GetAxis("Horizontal");
        float eixoZ =  Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(eixoX, 0, eixoZ);
        //transform.Translate(direction * Speed * Time.deltaTime);

        GetComponent<Rigidbody>().MovePosition
        (transform.position + 
        (direction * Speed * Time.deltaTime));
        
        
        if(direction != Vector3.zero)
        {
            GetComponent<Animator>().SetBool("Andar", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Andar", false);
        }
         
    }

}
