using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    public float speed = 10.0f;
    public float turnSpeed = 70.0f;
    public InputAction moveAction;
    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();
        // Move the vehicle forward
        // transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y); 
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * moveInput.x);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * moveInput.x);


    }
}
