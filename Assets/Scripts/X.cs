using UnityEngine;

public class X : MonoBehaviour
{
    private float yy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        yy = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, yy, 0);
        
    }
}
