using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Venus : MonoBehaviour
{
    public GameObject Venus_info;
    public GameObject Venus_model;
    public GameObject Venus_anim;
    public GameObject Venus_Blur_panel;
    public GameObject Venus_Back_panel;
    public GameObject Venus_Close_button;
    public GameObject Venus_Switch_planet;
    public GameObject layer_info;

    void Start()
    {
        Venus_model.gameObject.SetActive(true);
        Venus_info.gameObject.SetActive(false);
        Venus_anim.gameObject.SetActive(false);
        Venus_Blur_panel.gameObject.SetActive(false);
        Venus_Back_panel.gameObject.SetActive(false);
        Venus_Close_button.gameObject.SetActive(false);
        Venus_Switch_planet.gameObject.SetActive(false);
        layer_info.gameObject.SetActive(false);
    }


    public void Venus_info_show()
    {
        Venus_info.gameObject.SetActive(true);
        Venus_Blur_panel.gameObject.SetActive(true);
        Venus_Back_panel.gameObject.SetActive(true);
        Venus_Close_button.gameObject.SetActive(true);

    }

    public void close_Venus_panel()
    {
        Venus_info.gameObject.SetActive(false);
        Venus_Blur_panel.gameObject.SetActive(false);
        Venus_Back_panel.gameObject.SetActive(false);
        Venus_Close_button.gameObject.SetActive(false);
        Venus_Switch_planet.gameObject.SetActive(false);
    }

    public void Venus_show_structure()
    {
        Venus_model.gameObject.SetActive(false);
        Venus_anim.gameObject.SetActive(true);
        layer_info.gameObject.SetActive(true);
        Venus_Back_panel.gameObject.SetActive(false);
        Venus_Close_button.gameObject.SetActive(false);
        Venus_info.gameObject.SetActive(false);
        Venus_Blur_panel.gameObject.SetActive(false);
    }

    public void Swtch_planet()
    {
        Venus_Switch_planet.gameObject.SetActive(true);
        Venus_Close_button.gameObject.SetActive(true);
    }

    void Update()
    {
        
    }
}
