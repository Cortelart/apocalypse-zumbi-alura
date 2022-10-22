using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class NewEnemy : MonoBehaviour
{
    private GameObject player;
    private UnityEngine.AI.NavMeshAgent navMesh;
    Vector3 destination;
    private bool CanAttack;

    // Start is called before the first frame update
    void Start()
    {
        CanAttack = true;
        player = GameObject.FindWithTag ("Player");
        navMesh = GetComponent<UnityEngine.AI.NavMeshAgent>();
        
    }
    

    // Update is called once per frame
    void Update()
    {
        navMesh.destination = player.transform.position;
      
    }

    IEnumerator TimeAttack()
    {
            CanAttack = true;
            yield return new WaitForSeconds (3);
            CanAttack = false;
    }

    void Attack()
    {
        if (CanAttack == true){
            StartCoroutine ("TimeAttack");
            player.GetComponent <Player>().Vida -= 40;
        }
    }
    
    void OnCollisionEnter(Collision other)
    {

        if (CanAttack == true){
            Attack();
        }
        if(other.collider.tag == "Player")
        {
            Attack(); 
            Debug.Log ("Attack!");}
       
    }
}
