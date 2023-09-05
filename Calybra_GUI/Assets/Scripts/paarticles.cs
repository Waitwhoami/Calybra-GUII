using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paarticles : MonoBehaviour
{
    SpriteRenderer sr;
    CircleCollider2D c2d;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        c2d = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)) {
            sr.enabled = false;
            c2d.enabled = false;


        }


    }
}
