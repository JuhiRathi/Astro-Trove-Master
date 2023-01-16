using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetCollision : MonoBehaviour
{

    Change_material_Mercury Mercurymaterial;
    Change_material_Earth Earthmaterial;   
    Change_material_Venus Venusmaterial;
    Change_material_Mars Marsmaterial;
    Change_material_Jupiter Jupitermaterial;
    Change_material_Saturn Saturnmaterial;
    Change_material_Uranus Uranusmaterial;
    Change_material_Neptune Neptunematerial;

    void Start()
    {
        Earthmaterial = FindObjectOfType<Change_material_Earth>();
        Mercurymaterial = FindObjectOfType<Change_material_Mercury>();
        Venusmaterial = FindObjectOfType<Change_material_Venus>();
        Marsmaterial = FindObjectOfType<Change_material_Mars>();
        Jupitermaterial = FindObjectOfType<Change_material_Jupiter>();
        Saturnmaterial = FindObjectOfType<Change_material_Saturn>();
        Uranusmaterial = FindObjectOfType<Change_material_Uranus>();
        Neptunematerial = FindObjectOfType<Change_material_Neptune>();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Mercury")
        {
            Mercurymaterial.changeToSolid_Mercury();
            //Explore_mercury.gameObject.SetActive(true);
        }

        if (other.gameObject.tag == "Venus")
        {
            Venusmaterial.changeToSolid_Venus();
            //Explore_Venus.gameObject.SetActive(true);
        }
        if (other.gameObject.tag == "Earth")
        { 
            Earthmaterial.ChangeToSolid_Earth();
            //Explore_Earth.gameObject.SetActive(true);
        }

        if (other.gameObject.tag == "Mars")
        {
            Marsmaterial.changeToSolid_Mars();
            //Explore_Mars.gameObject.SetActive(true);
        }

        if (other.gameObject.tag == "Jupiter")
        {
            Jupitermaterial.changeToSolid_Jupiter();
            //Explore_Jupiter.gameObject.SetActive(true);
        }

        if (other.gameObject.tag == "Saturn")
        {
            Saturnmaterial.changeToSolid_Saturn();
            //Explore_Saturn.gameObject.SetActive(true);
        }

        if (other.gameObject.tag == "Uranus")
        {
            Uranusmaterial.changeToSolid_Uranus();
            //Explore_Uranus.gameObject.SetActive(true);
        }

        if (other.gameObject.tag == "Neptune")
        {
            Neptunematerial.changeToSolid_Neptune();
            //Explore_Neptune.gameObject.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Mercury")
        {
            Mercurymaterial.changeToTransparent_Mercury();
            //Explore_mercury.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Venus")
        {
            Venusmaterial.changeToTransparent_Venus();
            //Explore_Venus.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Earth")
        {
            Earthmaterial.ChangeToTransparent_Earth();
            //Explore_Earth.gameObject.SetActive(false);
        }
 
        if (other.gameObject.tag == "Mars")
        {
            Marsmaterial.changeToTransparent_Mars();
            //Explore_Mars.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Jupiter")
        {
            Jupitermaterial.changeToTransparent_Jupiter();
            //Explore_Jupiter.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Uranus")
        {
            Uranusmaterial.changeToTransparent_Uranus();
            //Explore_Uranus.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Saturn")
        {
            Saturnmaterial.changeToTransparent_Saturn();
            //Explore_Saturn.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Neptune")
        {
            Neptunematerial.changeToTransparent_Neptune();
            //Explore_Neptune.gameObject.SetActive(false);
        }
    }
}
