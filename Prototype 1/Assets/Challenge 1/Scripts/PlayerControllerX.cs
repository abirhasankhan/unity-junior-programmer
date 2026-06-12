using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    public InputAction moveAction;

    private Vector2 moveInput;

    public GameObject propeller;

    private Vector3 spin = new Vector3(0, 0, 400);



    // Start is called before the first frame update
    void Start()
    {
        moveAction.Enable();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = moveAction.ReadValue<Vector2>();
        // get the user's vertical input
        // verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.x);

        // if (moveInput.x != 0)
        // {
        //     // tilt the plane up/down based on up/down arrow keys
        //     transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * moveInput.y);
        // }

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime *  moveInput.y);

        propeller.transform.Rotate(Time.deltaTime * spin) ;

    }
}
