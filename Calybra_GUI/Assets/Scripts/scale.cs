using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR;

public class scale : MonoBehaviour
{
    [SerializeField] public int tCounter = 0; //How many objects are touching the left or right plate
    [SerializeField] public static int getThat2 = 3;        //1 - Both plates are touched    2 - One plate is touched    3 - Neither of the plates is touched
    Vector2 lpos;                                    //The original position of the left plate
    Vector2 rpos;
    [SerializeField] public GameObject holds;      //The line on top that rotates as the plate is held down
    [SerializeField] public GameObject lp;
    [SerializeField] public GameObject rp;
    // Start is called before the first frame update
    void Start()
    {
        lpos = lp.transform.position;
        rpos = rp.transform.position;
    }

    // Update is called once per frame              
    void Update()
    {
        Debug.Log("tCounter: " + tCounter);
        Debug.Log(gameObject.name + " plates touched: " + (getThat2 - 1));
        if(tCounter > 0)
        {
            
            getThat2--;
            if (getThat2 < 1)
            {
                getThat2 = 1;
            }


        }
        else if(tCounter == 0)
        {
            getThat2++;
            if (getThat2 > 3)
            {
                getThat2 = 3;
            }
        }

        if (getThat2 == 3) {            //When there's no object touching the left plate, it gets reset to its
            //lp.transform.position = lpos;   //original position
            //rp.transform.position = rpos;
            
        }
        //Debug.Log("Peso registrato: " + (pos.y - lp.transform.position.y) + "kg");
        //The weight is calculated by subtracting the current y position of the left plate to its original one
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        tCounter++;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        tCounter--;
    }


}/*
  * getThat2++;

            if (getThat2 < 3)
            { 


            else
            {
                getThat2--;
                if (getThat2 < 1) { 
                        getThat2 = 1; 
                }
            }

            }
  */ 
