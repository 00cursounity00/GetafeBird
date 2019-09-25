using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    Rigidbody rbPajaro;

    private void Start()
    {
        rbPajaro = GameObject.Find("Pajaro").GetComponent<Rigidbody>();
    }

    public void Jugar()
    {
        GameManager.playing = true;
        rbPajaro.isKinematic = false;
    }

    public void Reiniciar()
    {
        GameManager.Reload();
    }
}
