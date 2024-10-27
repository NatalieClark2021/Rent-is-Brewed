using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customerColl : MonoBehaviour
{
 
    public GameObject animatorObject; 
    private animationCustom customerScript; 
    void Start()
    {
      
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Customer"))
        {   
            customerScript = other.GetComponent<animationCustom>();
            customerScript.isMoving = false;
            customerScript.isTurning = true;

        }


        }

    }

