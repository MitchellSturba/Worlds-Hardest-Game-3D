using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{

    public GameObject player;       //Public variable to store a reference to the player game object
    public bool ThreeDee = false;
    private Vector3 offset;         //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        if (ThreeDee)
        {
            transform.position = player.transform.position + offset;
            transform.eulerAngles = new Vector3(70, 270, 0);
        }
        if (Input.GetKeyDown(KeyCode.P)) ThreeDee = !ThreeDee;
        if (!ThreeDee)
        {
            Vector3 newPo1 = new Vector3(-2.99f, 32.91f, 7.54f);
            transform.position = newPo1;
            transform.eulerAngles = new Vector3(90, 270, 0);
        }


    }
}
