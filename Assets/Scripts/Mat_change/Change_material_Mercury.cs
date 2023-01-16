using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_material_Mercury : MonoBehaviour
{
    public Material transparent_Mercury;
    public Material Solid_Mercury;

    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material = transparent_Mercury;

    }
    public void changeToSolid_Mercury()
    {
        gameObject.GetComponent<MeshRenderer>().material = Solid_Mercury;
    }
    public void changeToTransparent_Mercury()
    {
        gameObject.GetComponent<MeshRenderer>().material = transparent_Mercury;
    }

}
