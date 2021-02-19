using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractivePropOrange : MonoBehaviour
{
    public GameObject splashDecal;
    private bool squashed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
        When an orange has been stepped over by the player or driven oven by a cart, 
        plays a sound, then replaces the orange with a splash decal.
    */
    void OnTriggerEnter(Collider other) {
        if (!squashed && (other.name == "FPSController" || other.tag == "prop_movable")) {
            GetComponent<AudioSource>().Play();
            GetComponent<MeshRenderer>().enabled = false;
            Instantiate(splashDecal, new Vector3(transform.position.x-0.46f, transform.position.y, transform.position.z+0.512f), Quaternion.identity);
            squashed = true;
        }
    }
}
