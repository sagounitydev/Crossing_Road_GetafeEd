using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltaPollo : MonoBehaviour
{

    private Rigidbody rb;
    [SerializeField] int fuerza = 100;
    [SerializeField] Transform posPies;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            Collider[] cols = Physics.OverlapSphere(posPies.position, 10);
            for (int i=0; i <cols.Length; i++)
            {
                Debug.Log("ESTOY TOCANDO UN" + i);
            }

            rb.AddForce(new Vector3 (1,1,0) * fuerza);
        }
        else if (Input.GetKeyDown("w"))
        {
            Collider[] cols = Physics.OverlapSphere(posPies.position, 1f, LayerMask.NameToLayer("Terreno"));
            for (int i = 0; i < cols.Length; i++)
            {
                Debug.Log("ESTOY TOCANDO UN" + i);
            }

            rb.AddForce(new Vector3(-1, 1, 0) * fuerza);
        }
        else if (Input.GetKeyDown("d"))
        {
            Collider[] cols = Physics.OverlapSphere(posPies.position, 10);
            for (int i = 0; i < cols.Length; i++)
            {
                Debug.Log("ESTOY TOCANDO UN" + i);
            }

            rb.AddForce(new Vector3(0, 1, 1) * fuerza);
        }
        else if (Input.GetKeyDown("a"))
        {
            Collider[] cols = Physics.OverlapSphere(posPies.position, 10);
            for (int i = 0; i < cols.Length; i++)
            {
                Debug.Log("ESTOY TOCANDO UN" + i);
            }

            rb.AddForce(new Vector3(0, 1, -1) * fuerza);
        }
    }
}