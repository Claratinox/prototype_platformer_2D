using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class movement : MonoBehaviour
{
    //I create a float to be able to change the speed value easily :
    [SerializeField] float speed = 5f;

    //I code each of the movements in a fonction I created :
    private void Movement()
    {

        //Move right:
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        //Move left:

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

    //I call my function "Movement" in the update so the object moves each time I press a key :
    void Update()
    {
        Movement();
    }
}