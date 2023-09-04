using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale : MonoBehaviour
{
    [SerializeField] int tCounter = 0;              //How many objects are touching the left plate
    Vector2 pos;                                    //The original position of the left plate
    Quaternion rot;                                 //The original orientation of the line on top
    [SerializeField] public GameObject holds;      //The line on top that rotates as the plate is held down
    // Start is called before the first frame update
    void Start()
    {
        rot = transform.rotation;
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {   
        if (tCounter == 0) {            //When there's no object touching the left plate, it gets reset to its
            transform.position = pos;   //original position
            holds.transform.rotation = rot;
        }
        Debug.Log("Peso registrato: " + (pos.y - transform.position.y) + "kg");
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

     
}
