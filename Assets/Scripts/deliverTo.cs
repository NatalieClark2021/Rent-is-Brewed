using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deliverTo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    Player pScr;
    public GameObject fullmugPrefab;
    public Transform deliveryStation;
    public Transform hand;

    private GameObject fullMugInstance;


    public bool getE = false;
    private void Start()
    {
        pScr = player.GetComponent<Player>();
    }
    

    // Update is called once per frame
    private void OnTriggerStay(Collider other){
        if (other.CompareTag("Player"))
        {
  
           Debug.Log("deliver Coffee");
            if(Input.GetKey(KeyCode.E) && pScr.inHand){
                
                Debug.Log("Full mug before destroy: " + pScr.fullMug);
                Destroy(pScr.fullMug);
                pScr.fullMug = null;
                pScr.inHand = false;
                fullMugInstance = Instantiate(fullmugPrefab, deliveryStation.position, deliveryStation.rotation);
                fullMugInstance.transform.SetParent(deliveryStation);

 
            }


        }
    }}
