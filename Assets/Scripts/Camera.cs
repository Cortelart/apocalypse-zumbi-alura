using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public GameObject Player;
    Vector3 distCompensar;

    // Start is called before the first frame update
    void Start()
    {
        distCompensar = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + distCompensar;
    }
    
}
