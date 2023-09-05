using UnityEngine;

public class rotatin : MonoBehaviour
{
    [SerializeField] float r = 50;      //Rotating speed
    [SerializeField] float v = 50;      //Moving speed

    //It's probably better to change those speeds in the inspector: as a matter of fact, the values in this script are not correct. I added SerializeField for a reason. Click on the bucket in the scene hiererchy
    //and scroll down until you see this component script attached to the gameobject.

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.freezeRotation = true;       //This prevents some bad bugs. I reckon to keep it like that
    }

    // Update is called once per frame
    void Update()
    {
        if (!rb.useAutoMass)    //When the user wants to move the bucket around, I make it have a gigantasourus mass, so that the mass of the particles won't drag it down. Gravity is also deactivated.
        {
            rb.mass = 1000000;
            rb.gravityScale = 0f;
        }


        //this part could probably be written a bit more elegantly

        if (Input.GetKeyDown(KeyCode.Space))
        {      //Move the bucket / Release the bucket to weigh it

            rb.useAutoMass = !rb.useAutoMass;
            rb.gravityScale = 1f;           //With no gravity, if the bucket has nothing inside it ain't gonna fall nohow lols
        }

        if (Input.GetKey(KeyCode.LeftArrow))         //Rotate to the left
        {
            transform.Rotate(0f, 0f, r * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))       //Rotate to the right
        {
            transform.Rotate(0f, 0f, -r * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))          //Set bucket upwards
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        
        if (Input.GetKey(KeyCode.DownArrow))        //Set bucket downwards
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 180f);
        }

        if (Input.GetKey(KeyCode.A))                //Move left
        {
            transform.Translate(-v * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.D))                //Move right
        {
            transform.Translate(v * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.W))                //Move up
        {
            transform.Translate(0f, v * Time.deltaTime, 0f);
        }

        if (Input.GetKey(KeyCode.S))                //Move down
        {
            transform.Translate(0f, -v * Time.deltaTime, 0f);
        }


    }
}
