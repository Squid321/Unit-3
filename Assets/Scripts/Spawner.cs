using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Objects;
    private Vector3 spawnpos = new Vector3(25, 0, 0);
    public float startDelay;
    public float spawnDelay;
    private int Index;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Spawn", startDelay, spawnDelay);
        
    }

    // Update is called once per frame
    void Spawn()
    {
        if (Index == 0) {
            Index = 1;
        }
        
        if (Index == 5) {
            Index = 0;
        }
        if (Index > 0) {
            Index = Random.Range(0, Objects.Length);
        }
        
        Instantiate(Objects[Index], spawnpos, Objects[Index].transform.rotation);
    }
}
