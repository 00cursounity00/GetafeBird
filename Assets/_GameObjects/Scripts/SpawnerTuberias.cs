using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTuberias : MonoBehaviour
{
    public GameObject prefabTuberia;
    float ratio = 1.2f;

    // Start is called before the first frame update
    void Start()
    {        
        InvokeRepeating("SpawnTuberia", 0, ratio);
    }
    
    void SpawnTuberia ()
    {
        if (GameManager.playing == true) {

            Instantiate(prefabTuberia, transform);
        }
    }
}
