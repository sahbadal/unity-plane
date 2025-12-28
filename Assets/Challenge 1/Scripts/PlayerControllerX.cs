using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20f;
    public float rotationSpeed = 50f;
    private float verticalInput;

    void FixedUpdate()
    {

        verticalInput = -Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * speed * Time.deltaTime);


        transform.Rotate(Vector3.right * verticalInput * rotationSpeed * Time.deltaTime);
    }
}
