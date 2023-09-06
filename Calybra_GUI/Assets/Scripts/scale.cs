using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR;

public class scale : MonoBehaviour
{
    [SerializeField] public static int getThat2 = 3;        //1 - Both plates are touched    2 - One plate is touched    3 - Neither of the plates is touched

    [SerializeField] public GameObject holds;      //The line on top that rotates as the plate is held down

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame              
    void Update()
    {
        //Debug.Log("Peso registrato: " + (pos.y - lp.transform.position.y) + "kg");
        //The weight is calculated by subtracting the current y position of the left plate to its original one
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
