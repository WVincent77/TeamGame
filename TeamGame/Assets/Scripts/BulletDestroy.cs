using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    private float TopDestroyer = 14;
    private float BottomDestroyer = -14;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Destroys bullets along X axis
        if (transform.position.x > TopDestroyer)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < BottomDestroyer)
        {
            Destroy(gameObject);
        }

        //Destroys bullets along Z axis
        if (transform.position.z > TopDestroyer)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < BottomDestroyer)
        {
            Destroy(gameObject);
        }
    }
}
