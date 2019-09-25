using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pajaro : MonoBehaviour
{
    public int puntuacion = 0;
    Rigidbody rb;
    AudioSource audioSource;
    [SerializeField] GameObject prefabSangre;
    private int fuerza = 1200;
    private int gravedad = 10;
    public Text txPuntuacion;
    [SerializeField] AudioClip sonidoAlas;
    [SerializeField] AudioClip sonidoPunto;
    [SerializeField] GameObject botonReload;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.down * gravedad);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Saltar();
        }
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
            Puntuar();
        }
    }

    private void Puntuar()
    {
        audioSource.PlayOneShot(sonidoPunto);
        puntuacion++;
        txPuntuacion.text = "Score: " + puntuacion.ToString();
    }

    private void Morir()
    {
        botonReload.SetActive(true);
        Instantiate(prefabSangre, transform.position, transform.rotation);
        GameManager.playing = false;
        Destroy(gameObject);
    }

    private void Saltar()
    {
        audioSource.PlayOneShot(sonidoAlas);
        rb.AddForce(Vector3.up * fuerza);
    }
}