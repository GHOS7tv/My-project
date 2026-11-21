using UnityEngine;
public class TunnelSpawner : MonoBehaviour
{
    [SerializeField] GameObject Tunnel;
    [SerializeField] float SpawnTime;
    float Timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetTime();
    }
    // Update is called once per frame
    void Update()
    {
        Timer = Timer - Time.deltaTime;
        if(Timer <= 0)
        {
            Spawn();
            SetTime();
        }
    }
    void SetTime()
    {
        Timer = SpawnTime;
    }
    void Spawn()
    {
        Instantiate(Tunnel, new Vector3(0, 0, 10), Tunnel.transform.rotation);
    }
}