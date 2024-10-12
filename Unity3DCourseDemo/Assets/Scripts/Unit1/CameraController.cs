using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public PlayerController playerController;
    public Vector3 offset = new Vector3(0, 5, -7);
    void Start()
    {

    }

    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 position = playerController.transform.position + offset;
        transform.position = position;
    }
}
