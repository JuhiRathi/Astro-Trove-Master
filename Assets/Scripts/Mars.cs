using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mars : MonoBehaviour
{
    public GameObject Mars_info;
    public GameObject Mars_model;
    public GameObject Mars_anim;
    public GameObject Mars_Blur_panel;
    public GameObject Mars_Back_panel;
    public GameObject Mars_Close_button;
    public GameObject Mars_Switch_planet;
    public GameObject layer_info;

    void Start()
    {
        Mars_model.gameObject.SetActive(true);
        Mars_info.gameObject.SetActive(false);
        Mars_anim.gameObject.SetActive(false);
        Mars_Blur_panel.gameObject.SetActive(false);
        Mars_Back_panel.gameObject.SetActive(false);
        Mars_Close_button.gameObject.SetActive(false);
        Mars_Switch_planet.gameObject.SetActive(false);
        layer_info.gameObject.SetActive(false);
    }


    public void Mars_info_show()
    {
        Mars_info.gameObject.SetActive(true);
        Mars_Blur_panel.gameObject.SetActive(true);
        Mars_Back_panel.gameObject.SetActive(true);
        Mars_Close_button.gameObject.SetActive(true);

    }

    public void close_Mars_panel()
    {
        Mars_info.gameObject.SetActive(false);
        Mars_Blur_panel.gameObject.SetActive(false);
        Mars_Back_panel.gameObject.SetActive(false);
        Mars_Close_button.gameObject.SetActive(false);
        Mars_Switch_planet.gameObject.SetActive(false);
    }

    public void Mars_show_structure()
    {
        Mars_model.gameObject.SetActive(false);
        Mars_anim.gameObject.SetActive(true);
        Mars_Back_panel.gameObject.SetActive(false);
        Mars_Close_button.gameObject.SetActive(false);
        Mars_info.gameObject.SetActive(false);
        Mars_Blur_panel.gameObject.SetActive(false);
        layer_info.gameObject.SetActive(true);
    }

    public void Swtch_planet()
    {
        Mars_Switch_planet.gameObject.SetActive(true);
        Mars_Close_button.gameObject.SetActive(true);
    }

    void Update()
    {
        
    }
}
