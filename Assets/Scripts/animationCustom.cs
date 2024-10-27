using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class animationCustom : MonoBehaviour
{
    // Start is called before the first frame update

    Animator animator;
    public float speed;
    public bool isMoving = false; 
    public bool isTurning = false; 
    public Transform deliveryStation;

    public bool isCustomer = true; 
    void Start()
    {
        animator = GetComponent<Animator>();

        animator.SetBool("isIdle" ,true);
        isMoving = true;
    }

    // Update is called once per frame
    void Update()
    {

        if(isMoving){
            animator.SetBool("isIdle" ,false);
            animator.SetBool("isWalk" ,true);
            transform.Translate(0,0, speed);
        }


        if(isTurning){
    
    
            animator.SetBool("isWalk" , false);
            animator.SetBool("isIdle", true);
            transform.Rotate(0, 90, 0);
            isTurning = false;


        }



        if (deliveryStation.transform.childCount>0 && animator.GetBool("isIdle"))
        {
            

            Transform child = deliveryStation.transform.GetChild(0);
            Destroy(child.gameObject);
            transform.Rotate(0, -90, 0);
            isMoving = true;
            isCustomer = false;

        }

    }
    



}
