using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{
    public int randomInitialIndex;
    public List<GameObject> animalPrefabs;
    public float xRange = 15;

    public float initAnimalTime = 3;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnAnimal), 3, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnAnimal()
    {
        float xPos = Random.Range(-xRange, xRange);
        Vector3 vector3 = new Vector3(xPos, 0, 20);
        randomInitialIndex = Random.Range(0, animalPrefabs.Count);
        GameObject gameObject = animalPrefabs[randomInitialIndex];
        Instantiate(gameObject, vector3, gameObject.transform.rotation);
    }
}
