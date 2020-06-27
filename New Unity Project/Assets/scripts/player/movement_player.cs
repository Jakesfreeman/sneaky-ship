using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_player : MonoBehaviour
{
    private Transform tf; // A variable to hold our Transform component
    public int speed = 5;
    public float rotatespeed;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        //movement if statements for moving once a key press while hold left shift


        if (Input.GetKey(KeyCode.LeftArrow)) // rotates left
        {
            tf.Rotate(0.0f, 0.0f, rotatespeed);
        }

        if (Input.GetKey(KeyCode.RightArrow)) //rotates right
        {
            tf.Rotate(0.0f, 0.0f, -rotatespeed);
        }

        if (Input.GetKey(KeyCode.UpArrow)) //move forward
        {
            tf.position += tf.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow)) // move back
        {
            tf.position += -tf.up * speed * Time.deltaTime;
        }
    }
}
