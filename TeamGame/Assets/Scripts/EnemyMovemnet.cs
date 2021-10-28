using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovemnet : MonoBehaviour
{
    public float speed = 2.0f;
    private Rigidbody zombieRB;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        zombieRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        //zombieRB.AddForce(lookDirection * speed);
    }
}
