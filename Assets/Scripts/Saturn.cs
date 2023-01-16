using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saturn : MonoBehaviour
{
    public GameObject Saturn_info;
    public GameObject Saturn_model;
    public GameObject Saturn_anim;
    public GameObject Saturn_Blur_panel;
    public GameObject Saturn_Back_panel;
    public GameObject Saturn_Close_button;
    public GameObject Saturn_Switch_planet;
    public GameObject layer_info;


    void Start()
    {
        Saturn_model.gameObject.SetActive(true);
        Saturn_info.gameObject.SetActive(false);
        Saturn_anim.gameObject.SetActive(false);
        Saturn_Blur_panel.gameObject.SetActive(false);
        Saturn_Back_panel.gameObject.SetActive(false);
        Saturn_Close_button.gameObject.SetActive(false);
        Saturn_Switch_planet.gameObject.SetActive(false);
        layer_info.gameObject.SetActive(false);
    }


    public void Saturn_info_show()
    {
        Saturn_info.gameObject.SetActive(true);
        Saturn_Blur_panel.gameObject.SetActive(true);
        Saturn_Back_panel.gameObject.SetActive(true);
        Saturn_Close_button.gameObject.SetActive(true);

    }

    public void close_Saturn_panel()
    {
        Saturn_info.gameObject.SetActive(false);
        Saturn_Blur_panel.gameObject.SetActive(false);
        Saturn_Back_panel.gameObject.SetActive(false);
        Saturn_Close_button.gameObject.SetActive(false);
        Saturn_Switch_planet.gameObject.SetActive(false);
        layer_info.gameObject.SetActive(true);
    }

    public void Saturn_show_structure()
    {
        Saturn_model.gameObject.SetActive(false);
        Saturn_anim.gameObject.SetActive(true);
        Saturn_Back_panel.gameObject.SetActive(false);
        Saturn_Close_button.gameObject.SetActive(false);
        Saturn_info.gameObject.SetActive(false);
        Saturn_Blur_panel.gameObject.SetActive(false);
    }

    public void Swtch_planet()
    {
        Saturn_Switch_planet.gameObject.SetActive(true);
        Saturn_Close_button.gameObject.SetActive(true);
    }

    void Update()
    {
        
    }
}
