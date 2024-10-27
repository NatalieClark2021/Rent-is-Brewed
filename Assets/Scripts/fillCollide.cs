using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fillCollide : MonoBehaviour
{
    AudioSource As;
    AudioClip pour;
    public GameObject player;
    Player pScr;
    public GameObject fullmugPrefab;
    public Transform hand;

    private GameObject fullMugInstance;


    public bool getE = false;
    private void Start()
    {       
        As = GetComponent<AudioSource>();
        pScr = player.GetComponent<Player>();
    }
    

    private void OnTriggerStay(Collider other){
        if (other.CompareTag("Player"))
        {
  
           Debug.Log("fill Coffee");
            if(Input.GetKey(KeyCode.E) && pScr.inHand&& pScr.fullMug == null){
                As.Play();
                Destroy(pScr.emptyMug);
                fullMugInstance = Instantiate(fullmugPrefab, hand.position, hand.rotation);
                fullMugInstance.transform.SetParent(hand);
                pScr.inHand = true;
                
                pScr.emptyMug = null;
                pScr.fullMug = fullMugInstance;
            }



        }
    }
}
