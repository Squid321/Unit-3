using UnityEngine;

public class Loop : MonoBehaviour
{
    private Vector3 start;
    public float end;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < start.x - end){
            transform.position = new Vector3 (start.x, transform.position.y, transform.position.z);
        }
    }
}
