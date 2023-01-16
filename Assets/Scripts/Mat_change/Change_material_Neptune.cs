using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_material_Neptune : MonoBehaviour
{
    public Material transparent_Neptune;
    public Material Solid_Neptune;

    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material = transparent_Neptune;

    }
    public void changeToSolid_Neptune()
    {
        gameObject.GetComponent<MeshRenderer>().material = Solid_Neptune;
    }
    public void changeToTransparent_Neptune()
    {
        gameObject.GetComponent<MeshRenderer>().material = transparent_Neptune;
    }

    internal void changeToTransparent_Saturn()
    {
        throw new NotImplementedException();
    }
}
