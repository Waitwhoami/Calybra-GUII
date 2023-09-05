using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paarticles : MonoBehaviour
{
    SpriteRenderer sr;
    CircleCollider2D c2d;
    Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        c2d = GetComponent<CircleCollider2D>();
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("nyeh");

            sr.enabled = !sr.enabled;
            c2d.enabled = !c2d.enabled;

            if (sr.enabled && c2d.enabled)
            {
                transform.position = pos;
            }

        }


    }
    //TODO: Finish commenting all this man
}
