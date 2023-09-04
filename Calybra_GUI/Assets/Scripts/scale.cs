using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale : MonoBehaviour
{
    bool isTouched = false;
    [SerializeField] int tCounter = 0;
    Vector2 pos;
    Quaternion rot;
    [SerializeField] public GameObject holds;
    // Start is called before the first frame update
    void Start()
    {
        rot = transform.rotation;
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {   
        if (tCounter == 0) {
            transform.position = pos;
            holds.transform.rotation = rot;
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
