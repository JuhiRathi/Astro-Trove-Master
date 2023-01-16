using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth_rotation : MonoBehaviour
{
    public Transform earth;
    public float rotationspeed = 1f;

    void Start()
    {
        earth.GetComponent<Transform>();   
    }

    // Update is called once per frame
    void Update()
    {
        earth.Rotate(new Vector3(0, rotationspeed, 0), Space.World); 
    }
}
