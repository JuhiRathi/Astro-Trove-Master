using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_material_Saturn : MonoBehaviour
{
    public Material transparent_Saturn;
    public Material Solid_Saturn;

    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material = transparent_Saturn;

    }
    public void changeToSolid_Saturn()
    {
        gameObject.GetComponent<MeshRenderer>().material = Solid_Saturn;
    }
    public void changeToTransparent_Saturn()
    {
        gameObject.GetComponent<MeshRenderer>().material = transparent_Saturn;
    }

}
