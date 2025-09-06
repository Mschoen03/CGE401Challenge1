using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Matt Schoen
 * Challenge1
 * Updated Cam-Follow-Player
 */

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(30, 0, 10);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
