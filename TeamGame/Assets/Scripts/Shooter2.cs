using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter2 : MonoBehaviour
{

    public GameObject shot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad8) || (Input.GetKeyDown(KeyCode.Alpha8)))
        {
            // Launch a projectile from player
            Instantiate(shot, transform.position, transform.rotation);
        }
    }
}
