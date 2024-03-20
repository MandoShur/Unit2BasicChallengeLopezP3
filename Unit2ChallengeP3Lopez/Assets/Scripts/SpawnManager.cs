using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] stuffToSpawn;
    public float howOften, delay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", delay, howOften);
    }

    // Update is called once per frame
    void Spawn()
    {
        int whereToSpawnX = Random.Range(-20, 20);
        int whichtoSpawn = Random.Range(0, 2);

        Instantiate(stuffToSpawn[whichtoSpawn], new Vector3(whereToSpawnX, 0, 40), stuffToSpawn[whichtoSpawn].transform.rotation);
    }
}
