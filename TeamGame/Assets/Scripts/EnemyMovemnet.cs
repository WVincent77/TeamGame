using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovemnet : MonoBehaviour
{
    public float speed = 2.0f;
    private Rigidbody zombieRB;
    private GameObject player;
    private GameObject[] players;

    // Start is called before the first frame update
    void Start()
    {
        zombieRB = GetComponent<Rigidbody>();
        

        players = GameObject.FindGameObjectsWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float D0 = (players[0].transform.position - transform.position).sqrMagnitude;
        float D1 = (players[1].transform.position - transform.position).sqrMagnitude;


        if (D0 < D1)
        {
            player = players[0];
        }
        else
        {
            player = players[1];
        }

        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        zombieRB.AddForce(lookDirection * speed);


       
    }
}
