using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float keyInput;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 8, ForceMode.VelocityChange);
        }


        keyInput = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody>().velocity = new Vector3(keyInput * 3, GetComponent<Rigidbody>().velocity.y, 0);
    }
}
