using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaterMover : MonoBehaviour
{
    bool left = false, right = false, up = false, down = false;
    float Playerspeed = 0.18f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (Input.GetKeyDown(KeyCode.S)) down = true;
        else if (Input.GetKeyDown(KeyCode.A)) left = true;
        else if (Input.GetKeyDown(KeyCode.D)) right = true;
        else if (Input.GetKeyDown(KeyCode.W)) up = true;

        if (left) transform.Translate(Vector3.left * Playerspeed);
        if (right) transform.Translate(Vector3.right * Playerspeed);
        if (up) transform.Translate(Vector3.forward * Playerspeed);
        if (down) transform.Translate(Vector3.forward * -Playerspeed);

        if (Input.GetKeyUp(KeyCode.S)) down = false;
        else if (Input.GetKeyUp(KeyCode.A)) left = false;
        else if (Input.GetKeyUp(KeyCode.D)) right = false;
        else if (Input.GetKeyUp(KeyCode.W)) up = false;

        if (Input.GetKeyDown(KeyCode.Space)) rb.AddForce(transform.up * 600f);
        if (transform.position.y > 4) rb.AddForce(transform.up * -700f);

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sphere")
        {
            Vector3 newPos = new Vector3(-8.34f, -2.28f, -14.26f);
            transform.position = newPos;
        }
    }
}
