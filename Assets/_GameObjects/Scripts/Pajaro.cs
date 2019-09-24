using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pajaro : MonoBehaviour
{
    public int puntuacion = 0;
    Rigidbody rb;
    [SerializeField] GameObject prefabSangre;
    private int fuerza = 650;
    public Text txPuntuacion;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Saltar();
        }
    }

    void Saltar()
    {
        rb.AddForce(Vector3.up * fuerza);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Morir();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Limite") == true)
        {
            Morir();           
        }

        else
        {
            puntuacion++;
            txPuntuacion.text = "Score: " + puntuacion.ToString();
        }
    }

    private void Morir ()
    {
        Instantiate(prefabSangre, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}