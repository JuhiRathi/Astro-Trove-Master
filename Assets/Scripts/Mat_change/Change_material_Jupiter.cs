using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_material_Jupiter : MonoBehaviour
{
    public Material transparent_Jupiter;
    public Material Solid_Jupiter;

    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material = transparent_Jupiter;

    }
    public void changeToSolid_Jupiter()
    {
        gameObject.GetComponent<MeshRenderer>().material = Solid_Jupiter;
    }
    public void changeToTransparent_Jupiter()
    {
        gameObject.GetComponent<MeshRenderer>().material = transparent_Jupiter;
    }

}
