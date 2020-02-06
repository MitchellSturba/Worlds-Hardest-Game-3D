using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRightObsticle : MonoBehaviour
{
    bool right = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (right) transform.Translate(Vector3.forward * 0.4f);
        else transform.Translate(Vector3.forward * -0.4f);

        if (transform.position.z > 19.20f) right = false;
        if (transform.position.z <= -4.7f) right = true;
    }
}
