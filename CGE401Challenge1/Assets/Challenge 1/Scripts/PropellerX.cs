using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Matt Schoen
 * Challenge1
 * Propller rotates
 */

public class PropellerX : MonoBehaviour
{
    public float rotationSpeed = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

    }
}
