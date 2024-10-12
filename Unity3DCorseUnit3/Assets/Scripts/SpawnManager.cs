using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obscablePrefab;
    private Vector3 spawnPosition = new Vector3(23,0,0);
    private PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle),1,2);
        player = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnObstacle() {
        if (player.isGameOver) {
            return;
        }
        Instantiate(obscablePrefab, spawnPosition,obscablePrefab.transform.rotation);
    }
}
