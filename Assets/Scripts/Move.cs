using UnityEngine;

public class Move : MonoBehaviour
{
    public float spd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * spd);
    }
}
