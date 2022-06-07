using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovementController : MonoBehaviour
{
    public float forwardInput;
    public float horizontalInput;
    public float player1Speed = 1;

    private ParticleSystem crashParticle;
    private Rigidbody playerRb;
    public TMP_Text scoreText;
    private float score = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        playerRb  = GetComponent<Rigidbody>();
        
        crashParticle = GetComponentInChildren<ParticleSystem>();
        
        scoreText.SetText("Yuh");
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        scoreText.SetText(" " + score);
    }

    void FixedUpdate() {
        float targetSpeed = 20;
        Vector3 targetVelocity = Vector3.forward * targetSpeed;
        Vector3 targetHvelocity = Vector3.right * targetSpeed;
        Vector3 force;
        Vector3 jumpForce = new Vector3 (0,250,0);
        float forceMultiplier = 3;
        if (Input.GetKeyDown(KeyCode.Space)) {
            playerRb.AddForce(jumpForce);
        }
        if (forwardInput > 0)
        {
            if(targetVelocity.z <= playerRb.velocity.z)
            {
                force = new Vector3(0, 0, 0);
            } else
            {
                force = (targetVelocity - playerRb.velocity) * forwardInput * forceMultiplier;
            }
            playerRb.AddForce(force);
        }
        if (forwardInput < 0)
        {
            if (-targetVelocity.z >= playerRb.velocity.z)
            {
                force = new Vector3(0, 0, 0);
            }
            else
            {
                force = (targetVelocity + playerRb.velocity) * forwardInput * forceMultiplier;
            }
            playerRb.AddForce(force);
        }

        if (horizontalInput > 0)
        {
            if (targetHvelocity.x <= playerRb.velocity.x)
            {
                force = new Vector3(0, 0, 0);
            }
            else
            {
                force = (targetHvelocity - playerRb.velocity) * horizontalInput * forceMultiplier;
            }
            playerRb.AddForce(force);
        }
        if (horizontalInput < 0)
        {
            if (-targetHvelocity.x >= playerRb.velocity.x)
            {
                force = new Vector3(0, 0, 0);
            }
            else
            {
                force = (targetHvelocity + playerRb.velocity) * horizontalInput * forceMultiplier;
            }
            playerRb.AddForce(force);
        }

    }

    private void OnCollisionEnter(Collision collision) {
        //for collisions with rigidbodies
        StartCoroutine(CrashParticle());
    }

    private void OnTriggerEnter(Collider other) {
        //for pickups and zones
        if(other.CompareTag("Finish")) {
            score++;
        }
    
    }
    
  

    IEnumerator CrashParticle() {
        crashParticle.Play();
        yield return new WaitForSeconds(0.3f);
        crashParticle.Stop();
        crashParticle.Clear();
    } 
}
