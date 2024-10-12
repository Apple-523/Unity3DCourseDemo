using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgRepeat : MonoBehaviour
{

    private Vector3 startPosition;
    private float repeatWidth;
    private PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
        player = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.isGameOver) {
            return;
        }
        if (transform.position.x < startPosition.x - repeatWidth) {
            transform.position = startPosition;
        }
    }
}
