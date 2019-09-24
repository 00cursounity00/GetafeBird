using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTuberias : MonoBehaviour
{
    public GameObject prefabTuberia;
    float ratio = 1.7f;

    // Start is called before the first frame update
    void Start()
    {        
        InvokeRepeating("SpawnTuberia", 0, ratio);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnTuberia ()
    {
        Instantiate(prefabTuberia, transform);
    }
}
