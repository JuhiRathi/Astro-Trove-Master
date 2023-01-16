using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]

public class ARTaptoPlaceObject : MonoBehaviour
{
    [SerializeField]private GameObject prefabObject;
    //public List<GameObject> galaxy = new List<GameObject>();
    //public GameObject[] arrayGalaxy = galaxy.ToArray[];

    public GameObject spawnedObject;
    public GameObject scanpanel;
    //public Ui_Buttons Tap;
    //public GameObject Stars;
    public GameObject Solar_system;
    public GameObject Planet_text;
    private Vector2 touchPosition;
    private ARRaycastManager _arRaycastManager;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();

    private void Awake()
    {
        _arRaycastManager = GetComponent<ARRaycastManager>();

    }
    private void Start()
    {
        scanpanel.gameObject.SetActive(true);
        Solar_system.gameObject.SetActive(false);
        Planet_text.gameObject.SetActive(false);
        //Stars.gameObject.SetActive(false);
        //Tap.gameObject.SetActive(false);

    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
                touchPosition = touch.position;

            if (_arRaycastManager.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon))
            {
                Pose hitPose = hits[0].pose;

                if (spawnedObject == null)
                    spawnedObject = Instantiate(prefabObject, hitPose.position, hitPose.rotation);
                    scanpanel.gameObject.SetActive(false);
                    Solar_system.gameObject.SetActive(true);
                    //Stars.gameObject.SetActive(true);
                    Planet_text.gameObject.SetActive(true);
                //Tap.gameObject.SetActive(true);
                //spawnedObject = GetComponent(prefabObject, hitPose.position, hitPose.rotation);
                /*else
                    spawnedObject.transform.position = hitPose.position;*/
            }
        }
    }

    public static implicit operator ARTaptoPlaceObject(GameObject v)
    {
        throw new NotImplementedException();
    }
    /*public void taphere()
    {
        //Tap.gameObject.SetActive(false);
        //Galaxy.gameObject.SetActive(true);
    }*/
}