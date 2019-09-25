using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuberias : MonoBehaviour
{
    public int velocidad;
    public float rango;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(0,Random.Range(rango*-1,rango),0);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.playing == true)
        {
            transform.Translate(Vector3.back * Time.deltaTime * velocidad);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Limite")
        
            Destroy(gameObject); 
    }
}
