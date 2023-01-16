using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_material_Uranus : MonoBehaviour
{
    public Material transparent_Uranus;
    public Material Solid_Uranus;

    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material = transparent_Uranus;

    }
    public void changeToSolid_Uranus()
    {
        gameObject.GetComponent<MeshRenderer>().material = Solid_Uranus;
    }
    public void changeToTransparent_Uranus()
    {
        gameObject.GetComponent<MeshRenderer>().material = transparent_Uranus;
    }

}

