using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - plane.transform.position;
    }

    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
        transform.LookAt(plane.transform);
    }
}
