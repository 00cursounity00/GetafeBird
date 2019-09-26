using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pajaro : MonoBehaviour
{
    Rigidbody rb;
    AudioSource audioSource;
    [SerializeField] GameObject prefabSangre;
    private int fuerza = 1300;
    private int gravedad = 20;
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
        if (GameManager.playing == true)
        {
            if (rb.GetPointVelocity(transform.position).y < 0 && transform.rotation.x < 0.2)
            {
                transform.Rotate(5, 0, 0);
            }

            else if (rb.GetPointVelocity(transform.position).y > 0 && transform.rotation.x > -0.2)
            {
                transform.Rotate(-15, 0, 0);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && rb.GetPointVelocity(transform.position).y < 0)
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
        GameManager.score++;
        txPuntuacion.text = "Score: " + GameManager.score.ToString();
    }

    private void Morir()
    {
        botonReload.SetActive(true);
        Instantiate(prefabSangre, transform.position, transform.rotation);
        GameManager.playing = false;
        GameManager.score = 0;
        Destroy(gameObject);
    }

    private void Saltar()
    {
        audioSource.PlayOneShot(sonidoAlas);
        rb.AddForce(Vector3.up * fuerza);
    }
}