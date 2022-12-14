using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public GameObject player;
    public float Velocidade = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 direcao = player.transform.position - transform.position;
        GetComponent<Rigidbody>().MovePosition
        (GetComponent<Rigidbody>().position + player.transform.position + direcao.normalized * Velocidade * Time.deltaTime);
    }
}
