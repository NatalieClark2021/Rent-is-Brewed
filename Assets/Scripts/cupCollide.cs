using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    Player pScr;
    public GameObject prefabEmptyMug;
    public Transform hand;

    private GameObject newMugInstance;

    public bool getE = false;
    private void Start()
    {
        // Get the Player component from the assigned player object
        pScr = player.GetComponent<Player>();
    }
    


    private void OnTriggerStay(Collider other){
        if (other.CompareTag("Player"))
        {

  
           Debug.Log("Grab Coffee");
            if(Input.GetKey(KeyCode.E) && !pScr.inHand){
           
            newMugInstance = Instantiate(prefabEmptyMug, hand.position, hand.rotation);
            newMugInstance.transform.SetParent(hand);
            pScr.inHand = true;
            
            }

            pScr.emptyMug = newMugInstance; 
            // Instantiate the coffee mug prefab in the scene

        }
    }
}
