using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20.0f;
    public float tiltSpeed;
    // public float rotationSpeed = 1000f;
    public float verticalInput;
    public float pitchSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        float pitchInput = Input.GetAxis("Vertical");
        float pitchAmount = pitchInput * pitchSpeed * Time.deltaTime;
       
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right, pitchAmount);
        transform.Rotate(Vector3.up, verticalInput * tiltSpeed * Time.deltaTime);
    }
}
