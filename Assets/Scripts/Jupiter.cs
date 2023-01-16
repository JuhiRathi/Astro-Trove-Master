using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jupiter : MonoBehaviour
{
    public GameObject Jupiter_info;
    public GameObject Jupiter_model;
    public GameObject Jupiter_anim;
    public GameObject Jupiter_Blur_panel;
    public GameObject Jupiter_Back_panel;
    public GameObject Jupiter_Close_button;
    public GameObject Jupiter_Switch_planet;
    public GameObject layer_info;

    void Start()
    {
        Jupiter_model.gameObject.SetActive(true);
        Jupiter_info.gameObject.SetActive(false);
        Jupiter_anim.gameObject.SetActive(false);
        Jupiter_Blur_panel.gameObject.SetActive(false);
        Jupiter_Back_panel.gameObject.SetActive(false);
        Jupiter_Close_button.gameObject.SetActive(false);
        Jupiter_Switch_planet.gameObject.SetActive(false);
        layer_info.gameObject.SetActive(false);
    }


    public void Jupiter_info_show()
    {
        Jupiter_info.gameObject.SetActive(true);
        Jupiter_Blur_panel.gameObject.SetActive(true);
        Jupiter_Back_panel.gameObject.SetActive(true);
        Jupiter_Close_button.gameObject.SetActive(true);

    }

    public void close_Jupiter_panel()
    {
        Jupiter_info.gameObject.SetActive(false);
        Jupiter_Blur_panel.gameObject.SetActive(false);
        Jupiter_Back_panel.gameObject.SetActive(false);
        Jupiter_Close_button.gameObject.SetActive(false);
        Jupiter_Switch_planet.gameObject.SetActive(false);
    }

    public void Jupiter_show_structure()
    {
        Jupiter_model.gameObject.SetActive(false);
        Jupiter_anim.gameObject.SetActive(true);
        Jupiter_Back_panel.gameObject.SetActive(false);
        Jupiter_Close_button.gameObject.SetActive(false);
        Jupiter_info.gameObject.SetActive(false);
        Jupiter_Blur_panel.gameObject.SetActive(false);
        layer_info.gameObject.SetActive(true);
    }

    public void Swtch_planet()
    {
        Jupiter_Switch_planet.gameObject.SetActive(true);
        Jupiter_Close_button.gameObject.SetActive(true);
    }

    void Update()
    {
        
    }
}
