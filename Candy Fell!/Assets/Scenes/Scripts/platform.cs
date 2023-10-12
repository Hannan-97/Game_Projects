using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class platform : MonoBehaviour
{
    public int sceneName;
    public int nextScene;



    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.left*UnityEngine.Random.Range(0.1f, 1.2f), ForceMode.VelocityChange);   
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Candy"))
            SceneManager.LoadScene(nextScene);

        if (collision.gameObject.CompareTag("Respawn"))
            SceneManager.LoadScene(sceneName);
    }
}
