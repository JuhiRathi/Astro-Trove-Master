using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MakeItButton : MonoBehaviour
#pragma warning restore CS0164 // This label has not been referenced
{
    public GameObject button;
    public GameObject frs_phase;
    public GameObject stat_moon;

    void Start()
    {
        stat_moon.gameObject.SetActive(true);
        frs_phase.gameObject.SetActive(false);
    }

    void Update()
    {
    if (Input.GetMouseButtonDown(0))
        {
            stat_moon.gameObject.SetActive(false);
            frs_phase.gameObject.SetActive(true);
        }
    }

    private GameObject getClickedObject(out RaycastHit raycastHit)
    {
        throw new NotImplementedException();
    }

    private GameObject getClickedObject(out RaycastHit2D raycastHit)
    {
        throw new NotImplementedException();
    }
}
