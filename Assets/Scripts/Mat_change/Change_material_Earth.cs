using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_material_Earth : MonoBehaviour
{
    public Material transparent_Earth;
    public Material Solid_Earth;

    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material = transparent_Earth;

    }
    public void ChangeToSolid_Earth()
    {
        gameObject.GetComponent<MeshRenderer>().material = Solid_Earth;
    }
    public void ChangeToTransparent_Earth()
    {
        gameObject.GetComponent<MeshRenderer>().material = transparent_Earth;
    }
}