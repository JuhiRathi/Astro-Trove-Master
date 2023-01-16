using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planet_explore : MonoBehaviour
{



    public GameObject Explore_mercury;
    public GameObject Explore_Venus;
    public GameObject Explore_Earth;
    public GameObject Explore_Mars;
    public GameObject Explore_Jupiter;
    public GameObject Explore_Saturn;
    public GameObject Explore_Uranus;
    public GameObject Explore_Neptune;
    void Start()
    {
        Explore_mercury.gameObject.SetActive(false);
        Explore_Venus.gameObject.SetActive(false);
        Explore_Earth.gameObject.SetActive(false);
        Explore_Mars.gameObject.SetActive(false);
        Explore_Jupiter.gameObject.SetActive(false);
        Explore_Saturn.gameObject.SetActive(false);
        Explore_Uranus.gameObject.SetActive(false);
        Explore_Neptune.gameObject.SetActive(false);


    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Mercury")
        {
            Explore_mercury.gameObject.SetActive(true);
        }

        if (other.gameObject.tag == "Venus")
        {
            Explore_Venus.gameObject.SetActive(true);
        }
        if (other.gameObject.tag == "Earth")
        { 
            Explore_Earth.gameObject.SetActive(true);
        }

        if (other.gameObject.tag == "Mars")
        {
            Explore_Mars.gameObject.SetActive(true);
        }

        if (other.gameObject.tag == "Jupiter")
        {
            Explore_Jupiter.gameObject.SetActive(true);
        }

        if (other.gameObject.tag == "Saturn")
        {
            Explore_Saturn.gameObject.SetActive(true);
        }

        if (other.gameObject.tag == "Uranus")
        {

            Explore_Uranus.gameObject.SetActive(true);
        }

        if (other.gameObject.tag == "Neptune")
        {

            Explore_Neptune.gameObject.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Mercury")
        {
            Explore_mercury.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Venus")
        {
            Explore_Venus.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Earth")
        {
            Explore_Earth.gameObject.SetActive(false);
        }
 
        if (other.gameObject.tag == "Mars")
        {
            Explore_Mars.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Jupiter")
        {
            Explore_Jupiter.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Uranus")
        {
            Explore_Uranus.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Saturn")
        {
            Explore_Saturn.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Neptune")
        {
            Explore_Neptune.gameObject.SetActive(false);
        }
    }
}
