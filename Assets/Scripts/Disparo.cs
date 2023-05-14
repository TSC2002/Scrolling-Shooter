using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public Telaraña LaBala;
    public Transform PuntoDisparo;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(LaBala, PuntoDisparo.position, transform.rotation);
        }
    }
}
