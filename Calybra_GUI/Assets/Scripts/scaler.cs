using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaler : MonoBehaviour
{
    [SerializeField] public bool isTouched; //How many objects are touching the left or right plate
    Vector2 rpos;                                    //The original position of the left plate
    [SerializeField] public GameObject rp;
    // Start is called before the first frame update
    void Start()
    {
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

        if (scale.getThat2 == 3)
        {            //When there's no object touching the left plate, it gets reset to its
                    //rp.transform.position = rpos;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isTouched = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isTouched = false;
    }
}
