using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] float DoorCurrentSpeed = 1f;
    [SerializeField] float DoorAcceleration = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DoorCurrentSpeed += DoorAcceleration * Time.deltaTime;
        transform.position += new Vector3(0, 0, -2) * DoorCurrentSpeed * Time.deltaTime;
    }
}
