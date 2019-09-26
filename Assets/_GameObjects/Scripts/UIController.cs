using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    Rigidbody rbPajaro;
    Transform trPajaro;
    public GameObject prefabTuberia;

    private void Start()
    {
        rbPajaro = GameObject.Find("Pajaro").GetComponent<Rigidbody>();
    }

    public void Jugar()
    {
        GameManager.playing = true;
        GameManager.time = Time.realtimeSinceStartup;
        rbPajaro.isKinematic = false;
        Instantiate(prefabTuberia, new Vector3 (0,0,26), new Quaternion());
    }

    public void Reiniciar()
    {
        GameManager.Reload();
    }
}
