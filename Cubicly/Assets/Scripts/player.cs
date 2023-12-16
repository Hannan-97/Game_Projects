using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardSpeed;
    public float sidewaySpeed;
    public player movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);

       if (Input.GetKey("d"))
        {
           rb.AddForce(sidewaySpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaySpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardSpeed * Time.deltaTime);
        }

        if(rb.position.y<-1f)
        {
           FindAnyObjectByType<GameManager>().EndGame();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "obstacle") 
        {
            movement.enabled = false;
            FindAnyObjectByType<GameManager>().EndGame();
        }

    }
}
