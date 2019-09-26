using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fondo : MonoBehaviour
{
    public int velocidad;

   // Update is called once per frame
    void Update()
    {
        if (GameManager.playing == true)
        {
            transform.Translate(Vector3.right * Time.deltaTime * velocidad);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "LimiteFondo")
        {
            Destroy(gameObject);
        }
    }
}
