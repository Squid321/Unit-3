using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb; 
    public float jump = 15;
    public bool ground = true;
    public bool dead = false;
    public float grav = 1;
    private Animator playerAnim;
    public ParticleSystem explosionParticle;
    public ParticleSystem explosionParticle2;
    public ParticleSystem dirtParticle;
    public AudioClip crash;
    public AudioClip jumps;
    private AudioSource playerAudio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= 1;
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ground && !dead) {
            playerRb.AddForce(Vector3.up * jump, ForceMode.Impulse);
            ground = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumps, 1.0f);
        }
    }
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Ground")) {
            ground = true;
            dirtParticle.Play();
        } 
        if (collision.gameObject.CompareTag("Obstacle")) {
            dead = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            explosionParticle2.Play();
            dirtParticle.Stop();
            playerAudio.PlayOneShot(crash, 1.0f);
        }
        

    }
}
