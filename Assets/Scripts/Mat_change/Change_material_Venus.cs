using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_material_Venus : MonoBehaviour
{
    public Material transparent_Venus;
    public Material Solid_Venus;

    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material = transparent_Venus;

    }
    public void changeToSolid_Venus()
    {
        gameObject.GetComponent<MeshRenderer>().material = Solid_Venus;
    }
    public void changeToTransparent_Venus()
    {
        gameObject.GetComponent<MeshRenderer>().material = transparent_Venus;
    }

}
