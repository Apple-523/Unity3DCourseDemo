using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{


    public float speed = 3;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (transform.position.z > 50 || transform.position.z < -50)
        {
            Debug.Log("被销毁了"+transform.position.z);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<MoveForward>() != null)
        {
            Destroy(gameObject);
        }
    }
}
