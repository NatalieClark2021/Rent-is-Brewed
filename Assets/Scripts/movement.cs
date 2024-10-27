using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    
    AudioSource As;
    AudioClip music;

//     Music by: Bensound.com/free-music-for-videos
//     License code: BUVYANXXXSQQNSLK
    public TMPro.TextMeshProUGUI textObject;  
    public float speed;
    public int money;
    public bool inHand = false;
    public bool inDelivered = false;
    public float rot;
    public float rotSpeed;

    public GameObject emptyMug;
    public GameObject fullMug;
        void Start()
    {
        money = -88;
       As = GetComponent<AudioSource>();
       As.Play();
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(0,0, speed);
 
        }
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(-speed,0, 0);
            transform.Rotate(0, -rot,0);
        }
        if(Input.GetKey(KeyCode.S)){
            transform.Translate(0,0, -speed);

        }
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(speed,0, 0);
            transform.Rotate(0, rot,0);
        }

        textObject.text = money.ToString();

        if( money >= 0){
            gameOver();
        }

    }

    public static void gameOver(){
        SceneManager.LoadScene("Gameover", LoadSceneMode.Single);
    }




}
