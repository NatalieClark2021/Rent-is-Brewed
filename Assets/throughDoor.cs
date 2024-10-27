using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throughDoor : MonoBehaviour
{
    // Start is called before the first frame update

    AudioSource As;
    AudioClip doorBell;
    void Start()
    {
        As = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Customer"))
        {   
            As.Play();
        }


        }

    }

