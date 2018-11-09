using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltaPollo : MonoBehaviour
{

    private Rigidbody rb;
    [SerializeField] int fuerza = 100;
    [SerializeField] Transform posPies;
    [SerializeField] float distanciaDeteccion = 0.1f;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("s") && EstoyEnSuelo())
        {
            rb.AddForce(new Vector3 (2,2,0) * fuerza);
        }
        else if (Input.GetKeyDown("w") && EstoyEnSuelo())
        {
            rb.AddForce(new Vector3(-2, 2, 0) * fuerza);
        }
        else if (Input.GetKeyDown("d") && EstoyEnSuelo())
        {
            rb.AddForce(new Vector3(0, 2, 2) * fuerza);
        }
        else if (Input.GetKeyDown("a") && EstoyEnSuelo())
        {


            rb.AddForce(new Vector3(0, 2, -2) * fuerza);
        }
    }
    private bool EstoyEnSuelo()
    {
        int layerIndex = LayerMask.GetMask("Terreno");
        bool enSuelo = false;
        enSuelo = Physics.CheckSphere(posPies.position, distanciaDeteccion, layerIndex);
        return enSuelo;
    }
}