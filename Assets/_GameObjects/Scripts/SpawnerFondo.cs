using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerFondo : MonoBehaviour
{
    public GameObject prefabFondo;
    float ratio = 19.9f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFondo", 0, ratio);
    }

    void SpawnFondo()
    {
        if (GameManager.playing == true)
        {
            Instantiate(prefabFondo, transform);
        }
    }
}
