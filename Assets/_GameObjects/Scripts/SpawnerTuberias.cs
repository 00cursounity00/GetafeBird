using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTuberias : MonoBehaviour
{
    public GameObject prefabTuberia;
    float ratio = 2f;
    int limite = 1;
    int i = 0;

    // Start is called before the first frame update
    void Update()
    {
        if (GameManager.playing == true)
        {
            if ((Time.realtimeSinceStartup - GameManager.time) > ratio)
            {
                GameManager.time = Time.realtimeSinceStartup;
                Instantiate(prefabTuberia, transform);
                i++;
                if ((limite - i) == 0)
                {
                    limite = limite + 1;
                    i = 0;
                    ratio = ratio - 0.2f;
                }

            }
        }
    }
}
