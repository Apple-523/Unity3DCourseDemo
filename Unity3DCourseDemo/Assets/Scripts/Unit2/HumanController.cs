using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanController : MonoBehaviour
{
    public GameObject pizza;

    public float speed = 10;
    public float horizontalInput;

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        if (Input.GetKeyDown(KeyCode.Space)) {
            Vector3 position = transform.position;
            position.y = 1;
            Instantiate(pizza,position,Quaternion.identity);
        }
    }
}
