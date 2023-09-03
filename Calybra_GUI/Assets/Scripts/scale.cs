using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale : MonoBehaviour
{
    bool isTouched = false;
    [SerializeField] int tCounter = 0;
    Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {   
        if (tCounter == 0) {
            transform.position = pos;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        tCounter++;
        isTouched = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        tCounter--;
    }
}
