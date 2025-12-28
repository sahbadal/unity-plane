using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float speed = 1000f;

    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
