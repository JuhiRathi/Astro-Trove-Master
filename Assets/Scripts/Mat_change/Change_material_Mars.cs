using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_material_Mars : MonoBehaviour
{
    public Material transparent_Mars;
    public Material Solid_Mars;

    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material = transparent_Mars;

    }
    public void changeToSolid_Mars()
    {
        gameObject.GetComponent<MeshRenderer>().material = Solid_Mars;
    }
    public void changeToTransparent_Mars()
    {
        gameObject.GetComponent<MeshRenderer>().material = transparent_Mars;
    }

}
