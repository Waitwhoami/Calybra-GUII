using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalScale : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 nowPos;
    float fixW = 0.3198385f;
    // Start is called before the first frame update
    void Start()
    {
        nowPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log("Peso registrato: " + (transform.position.y - nowPos.y + (fixW)) + "kg");
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(rb.velocity.y <= 0 ) {
            rb.bodyType = RigidbodyType2D.Static;
        }
    }
}
