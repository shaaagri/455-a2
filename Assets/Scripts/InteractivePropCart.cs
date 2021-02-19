using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractivePropCart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
        Plays a sound upon an impact with walls
    */
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "environment" && collision.relativeVelocity.magnitude > 1.5) {
            GetComponent<AudioSource>().pitch = Random.Range(0.9f, 1.1f);
            GetComponent<AudioSource>().Play();
        }
    }
}
