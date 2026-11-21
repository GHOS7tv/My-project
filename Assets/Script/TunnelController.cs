using UnityEngine;

public class TunnelController : MonoBehaviour
{
    [SerializeField] float TunnelCurrentSpeed = 1f;
    [SerializeField] float TunnelSpeedAcceleration = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TunnelCurrentSpeed += TunnelSpeedAcceleration * Time.deltaTime;
        transform.position += new Vector3(0, 0, -1) * TunnelCurrentSpeed * Time.deltaTime;

        if (transform.position.z < -20)
        {
            Destroy(this.gameObject);
        }
    }
}
