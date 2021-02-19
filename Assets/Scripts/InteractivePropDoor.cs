using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractivePropDoor : MonoBehaviour
{
    private Rigidbody rb;
    private bool swinging = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Plays a hinge squeak sound when the player sets the door to swing
        if (!swinging) {
            if (Mathf.Abs(rb.angularVelocity.y) > 1.0f) {
                swinging = true;
                GetComponent<AudioSource>().Play();
            }
        }
        else {
            if (Mathf.Abs(rb.angularVelocity.y) < 0.4f) {
                swinging = false;
            }        
        }   
    }
}
