using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    Player pScr;
    private animationCustom customerScript; 
    public GameObject enemyPrefab;
    public GameObject newCustomer;
    public Transform deliveryStation;
    private bool sold = false;
    void Start()
    {
        customerScript = newCustomer.GetComponent<animationCustom>();
        customerScript.deliveryStation = deliveryStation;
        pScr = player.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!customerScript.isCustomer && !sold)
        {
        sold = true;
        StartCoroutine(waitSpawn());
        sellCoffee();
        }
    }

    IEnumerator waitSpawn()
    {
    
        yield return new WaitForSeconds(2);
        Destroy(newCustomer);
        newCustomer = Instantiate(enemyPrefab);
        customerScript = newCustomer.GetComponent<animationCustom>();
        customerScript.deliveryStation = deliveryStation;  
        sold = false;

    }

    void sellCoffee(){
        pScr.money +=7;
        Debug.Log("Sold some coffee: " + pScr.money);
    }
}
