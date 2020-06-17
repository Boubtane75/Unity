using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.1f;

    [SerializeField]
    private CharacterController controller;

    private float gravity = -9.81f;

    private Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            velocity.y = 1f;
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity);
        
        
    }
}
