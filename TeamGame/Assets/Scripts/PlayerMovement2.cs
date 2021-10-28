using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    private float angle = 45;

    public float XRange = 9;
    public float ZRange = 9;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Inputs
        horizontalInput = Input.GetAxis("AltHorizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("AltVertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        //Rotation Controls
        if (Input.GetKeyDown(KeyCode.C))
        {
            transform.Rotate(Vector3.up * angle);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.Rotate(-Vector3.up * angle);
        }
    }
}
