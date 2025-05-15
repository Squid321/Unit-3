using UnityEngine;

public class Timer : MonoBehaviour
{
    public float lifespan = 1000;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifespan -= 1;
        if (lifespan < 0){
            Destroy(gameObject);
        }
    }
}
