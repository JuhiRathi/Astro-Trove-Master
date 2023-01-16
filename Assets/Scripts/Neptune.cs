using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neptune : MonoBehaviour
{
    public GameObject Neptune_info;
    public GameObject Neptune_model;
    public GameObject Neptune_anim;
    public GameObject Neptune_Blur_panel;
    public GameObject Neptune_Back_panel;
    public GameObject Neptune_Close_button;
    public GameObject Neptune_Switch_planet;
    public GameObject layer_info;

    void Start()
    {
        Neptune_model.gameObject.SetActive(true);
        Neptune_info.gameObject.SetActive(false);
        Neptune_anim.gameObject.SetActive(false);
        Neptune_Blur_panel.gameObject.SetActive(false);
        Neptune_Back_panel.gameObject.SetActive(false);
        Neptune_Close_button.gameObject.SetActive(false);
        Neptune_Switch_planet.gameObject.SetActive(false);
        layer_info.gameObject.SetActive(false);
    }


    public void Neptune_info_show()
    {
        Neptune_info.gameObject.SetActive(true);
        Neptune_Blur_panel.gameObject.SetActive(true);
        Neptune_Back_panel.gameObject.SetActive(true);
        Neptune_Close_button.gameObject.SetActive(true);

    }

    public void close_Neptune_panel()
    {
        Neptune_info.gameObject.SetActive(false);
        Neptune_Blur_panel.gameObject.SetActive(false);
        Neptune_Back_panel.gameObject.SetActive(false);
        Neptune_Close_button.gameObject.SetActive(false);
        Neptune_Switch_planet.gameObject.SetActive(false);
    }

    public void Neptune_show_structure()
    {
        Neptune_model.gameObject.SetActive(false);
        Neptune_anim.gameObject.SetActive(true);
        Neptune_Back_panel.gameObject.SetActive(false);
        Neptune_Close_button.gameObject.SetActive(false);
        Neptune_info.gameObject.SetActive(false);
        Neptune_Blur_panel.gameObject.SetActive(false);
        layer_info.gameObject.SetActive(true);
    }

    public void Swtch_planet()
    {
        Neptune_Switch_planet.gameObject.SetActive(true);
        Neptune_Close_button.gameObject.SetActive(true);
    }

    void Update()
    {
        
    }
}
