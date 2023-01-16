using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uranus : MonoBehaviour
{
    public GameObject Uranus_info;
    public GameObject Uranus_model;
    public GameObject Uranus_anim;
    public GameObject Uranus_Blur_panel;
    public GameObject Uranus_Back_panel;
    public GameObject Uranus_Close_button;
    public GameObject Uranus_Switch_planet;
    public GameObject layer_info;

    void Start()
    {
        Uranus_model.gameObject.SetActive(true);
        Uranus_info.gameObject.SetActive(false);
        Uranus_anim.gameObject.SetActive(false);
        Uranus_Blur_panel.gameObject.SetActive(false);
        Uranus_Back_panel.gameObject.SetActive(false);
        Uranus_Close_button.gameObject.SetActive(false);
        Uranus_Switch_planet.gameObject.SetActive(false);
        layer_info.gameObject.SetActive(false);
    }


    public void Uranus_info_show()
    {
        Uranus_info.gameObject.SetActive(true);
        Uranus_Blur_panel.gameObject.SetActive(true);
        Uranus_Back_panel.gameObject.SetActive(true);
        Uranus_Close_button.gameObject.SetActive(true);

    }

    public void close_Uranus_panel()
    {
        Uranus_info.gameObject.SetActive(false);
        Uranus_Blur_panel.gameObject.SetActive(false);
        Uranus_Back_panel.gameObject.SetActive(false);
        Uranus_Close_button.gameObject.SetActive(false);
        Uranus_Switch_planet.gameObject.SetActive(false);
    }

    public void Uranus_show_structure()
    {
        Uranus_model.gameObject.SetActive(false);
        Uranus_anim.gameObject.SetActive(true);
        Uranus_Back_panel.gameObject.SetActive(false);
        Uranus_Close_button.gameObject.SetActive(false);
        Uranus_info.gameObject.SetActive(false);
        Uranus_Blur_panel.gameObject.SetActive(false);
        layer_info.gameObject.SetActive(true);
    }

    public void Swtch_planet()
    {
        Uranus_Switch_planet.gameObject.SetActive(true);
        Uranus_Close_button.gameObject.SetActive(true);
    }

    void Update()
    {
        
    }
}
