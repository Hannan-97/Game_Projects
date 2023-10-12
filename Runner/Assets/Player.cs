using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    
    // Start is called before the first frame update
    public Rigidbody ball;
    public float ballspeed;
    public Text score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = ball.position.z.ToString("0");


        if (Input.GetKey("w"))
            ball.AddForce(0f, 0f, ballspeed);

        if (Input.GetKey("s"))
            ball.AddForce(0f, 0f, -ballspeed);

        if (Input.GetKey("a"))
            ball.AddForce(-ballspeed, 0f, 0f);

        if (Input.GetKey("d"))
          ball.AddForce(ballspeed, 0f, 0f);

        if (ball.position.y < -5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
}
