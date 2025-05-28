using UnityEngine;

public class Move : MonoBehaviour
{
    public float spd;
    private float terminate = -15;
    private PlayerController playerControllerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.dead == false) {
        transform.Translate(Vector3.left * Time.deltaTime * spd);
        Debug.Log("You Died");
        }
        if (transform.position.x < terminate && gameObject.CompareTag("Obstacle")) {
            Destroy(gameObject);
        }
    }
}
