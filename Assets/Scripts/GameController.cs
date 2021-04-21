using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Global variables
    public GameObject cubePrefab; // Make it ready and dump the object in
    public int cubeAmount = 10;
    public float randomArea = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cubeAmount; i++)
        {
            GameObject cubeObject = Instantiate(cubePrefab);
            cubeObject.transform.position = new Vector3(
                Random.Range(-randomArea, randomArea), // Returns a random float within [minInclusive..maxInclusive] (range is inclusive).
                Random.Range(-randomArea, randomArea), // Returns a random float within [minInclusive..maxInclusive] (range is inclusive).
                0
            );
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
