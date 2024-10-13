using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10;
    public float forwardSpeed = 10;
    private Rigidbody rb;
    /// <summary>
    /// 是否在地面
    /// </summary>
    private bool isOnGround = true;
    public bool isGameOver;
    public float gravityModify = 1.7f;
    private Animator animator;

    public ParticleSystem smoke;
    public ParticleSystem bomb;

    public AudioClip jumpAudioClip;
    public AudioClip crashAudioClip;

    public AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModify;
        isGameOver = false;
        animator = GetComponent<Animator>();
        bomb.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !isGameOver)
        {
            //ForceMode.Impulse 冲击力
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            smoke.Stop();
            animator.SetTrigger("Jump_trig");
            audioSource.PlayOneShot(jumpAudioClip,1);
        }
        float x = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime * x);
    }

    private void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.CompareTag("Obscable")) {
            isGameOver = true;
            smoke.Stop();
            animator.SetBool("Death_b",true);
            bomb.Play();
            Debug.Log("game over!");
            audioSource.PlayOneShot(crashAudioClip,1);
        }
        if (other.gameObject.CompareTag("Ground")) {
            isOnGround = true;
            smoke.Play();
            // animator.SetBool("Jump_b",false);
        }

    }
}
