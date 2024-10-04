using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectsScript : MonoBehaviour
{
    public GameObject playerTakesDamageCube;
    public GameObject playerCanDestroyCube;
    public int AmountOfDamageCubes = 5;
    public int AmountOfDestroyCubes = 5;


    // Start is called before the first frame update
    void Start()
    {
        spawnPlayerTakesDamageCube();
        spawnPlayerCanDestroyCube();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnPlayerTakesDamageCube()
    {
        for (int i = 0; i < AmountOfDamageCubes; i++)
        {
            float x = Random.Range(-27, 27);
            float z = Random.Range(-27, 27);
            Vector3 pos = new Vector3(x, 2, z);

            Instantiate(playerTakesDamageCube, pos, Quaternion.identity);
        }
    }

    public void spawnPlayerCanDestroyCube()
    {
        for (int i = 0; i < AmountOfDestroyCubes; i++)
        {
            float x = Random.Range(-15, 15);
            float z = Random.Range(-15, 15);
            Vector3 pos = new Vector3(x, 2, z);

            Instantiate(playerCanDestroyCube, pos, Quaternion.identity);
        }
    }

}
