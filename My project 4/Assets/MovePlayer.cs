using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{
    
    void Start()
    {
        
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (transform.position.x < 5f)
            {
                transform.position = transform.position + new Vector3(5f, 0, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (transform.position.x > -5f)
            {
                transform.position = transform.position + new Vector3(-5f, 0, 0);
            }
        }
    }
    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "Enemies")
            SceneManager.LoadScene("SampleScene");
    }
}
