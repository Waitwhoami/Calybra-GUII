using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scalel : MonoBehaviour
{
    [SerializeField] public bool isTouched;
    Vector2 lpos;
    Vector2 rpos;
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
        Debug.Log(gameObject.name + " tCounter: " + isTouched);
        Debug.Log(gameObject.name + " plates touched: " + (scale.getThat2 - 1));
        if (isTouched)
        {

            scale.getThat2--;
            if (scale.getThat2 < 1)
            {
                scale.getThat2 = 1;
            }


        }
        else if (!isTouched)
        {
            scale.getThat2++;
            if (scale.getThat2 > 3)
            {
                scale.getThat2 = 3;
            }
        }



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isTouched = true;
        lp.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        rp.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isTouched = false;


        if (scale.getThat2 == 3)
        {            //When there's no object touching the left plate, it gets reset to its
            Debug.Log("yes");
            /* lp.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            lp.transform.position = lpos;
            rp.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            rp.transform.position = rpos;*/
           
            //Did i do it? did i really do it mangggg?
        }
    }
}
