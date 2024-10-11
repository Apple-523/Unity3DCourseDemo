using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3;
    public float rotateSpeed = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * y);
        transform.Rotate(new Vector3(0,rotateSpeed * Time.deltaTime * x,0));
    }
}
