using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArbolScript : MonoBehaviour {

    AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
        Invoke("DestruirObjeto", 0.032f);
    }

    void DestruirObjeto()
    {
        Destroy(gameObject);
    }
}
