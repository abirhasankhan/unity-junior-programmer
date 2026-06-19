using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction moveAction;
    public Vector2 moveInput;
    public float speed = 10.0f;

    public float xRange = 10.0f;

    void Start()
    {
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();

        if (transform.position.x < -10)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);   

        } else if (transform.position.x > 10)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }


        transform.Translate(Vector3.right * moveInput.x * Time.deltaTime * speed);
    }
}
