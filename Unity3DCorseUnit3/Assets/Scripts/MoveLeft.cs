using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    private PlayerController player;
    
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.isGameOver) {
            return;
        }
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x < -40 && gameObject.CompareTag("Obscable"))
        {
            Destroy(gameObject);
        }
    }
}
