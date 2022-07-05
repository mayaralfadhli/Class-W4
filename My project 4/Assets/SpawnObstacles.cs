using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject nemesisObject;
    public GameObject mrxObject;

    void Spawn()
    {
        GameObject spawnObject;
       
        int choice = Random.Range(0, 2);
        
        if (choice == 1)
            spawnObject = nemesisObject;
        else
            spawnObject = mrxObject;


        int newPosition = Random.Range(-1, 2);
        Vector3 vPosition = transform.position;
        vPosition.x = vPosition.x + (5 * newPosition);

        GameObject newSpawn = Instantiate(spawnObject);
        newSpawn.transform.position = vPosition;
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
