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

    public float gravityModify = 1.7f;
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModify;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            //ForceMode.Impulse 冲击力
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
        float x = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime * x);
    }

    private void OnCollisionEnter(Collision other)
    {
        isOnGround = true;
    }
}
