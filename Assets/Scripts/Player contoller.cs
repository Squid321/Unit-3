using UnityEngine;

public class Playercontoller : MonoBehaviour
{
    private Rigidbody playerRb; 
    public float jump = 15;
    public bool ground = true;
    public float grav = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ground) {
            playerRb.AddForce(Vector3.up * jump, ForceMode.Impulse);
            ground = false;
        }
    }
    private void OnCollisionEnter(Collision collision) {
        ground = true;
    }
}
