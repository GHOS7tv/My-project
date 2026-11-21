using UnityEngine;
public class DoorSpawner : MonoBehaviour
{
    [SerializeField] GameObject Door;


    float SpawnY;
    [SerializeField] float MinTimeToSpawn;
    [SerializeField] float MaxTimeToSpawn;
    float SpawnTime;
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
        if (Timer <= 0)
        { 
            Spawn();
            SetTime();
        }
    }
    void SetTime()
    {
        SpawnTime = Random.Range(MinTimeToSpawn, MaxTimeToSpawn);
        Timer = SpawnTime;
    }
    void Spawn()
    {
        Instantiate(Door);
    }
}