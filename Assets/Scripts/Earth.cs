using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Earth : MonoBehaviour
{
    public GameObject Earth_info;
    public GameObject Earth_model;
    public GameObject Earth_anim;
    public GameObject Earth_Blur_panel;
    public GameObject Earth_Back_panel;
    public GameObject Earth_Close_button;
    public GameObject Earth_Switch_planet;
    public GameObject layer_info;

    void Start()
    {
        Earth_model.gameObject.SetActive(true);
        Earth_info.gameObject.SetActive(false);
        Earth_anim.gameObject.SetActive(false);
        Earth_Blur_panel.gameObject.SetActive(false);
        Earth_Back_panel.gameObject.SetActive(false);
        Earth_Close_button.gameObject.SetActive(false);
        Earth_Switch_planet.gameObject.SetActive(false);
        layer_info.gameObject.SetActive(false);
    }


    public void Earth_info_show()
    {
        Earth_info.gameObject.SetActive(true);
        Earth_Blur_panel.gameObject.SetActive(true);
        Earth_Back_panel.gameObject.SetActive(true);
        Earth_Close_button.gameObject.SetActive(true);

    }

    public void close_Earth_panel()
    {
        Earth_info.gameObject.SetActive(false);
        Earth_Blur_panel.gameObject.SetActive(false);
        Earth_Back_panel.gameObject.SetActive(false);
        Earth_Close_button.gameObject.SetActive(false);
        Earth_Switch_planet.gameObject.SetActive(false);
    }

    public void Earth_show_structure()
    {
        Earth_model.gameObject.SetActive(false);
        Earth_anim.gameObject.SetActive(true);
        Earth_Back_panel.gameObject.SetActive(false);
        Earth_Close_button.gameObject.SetActive(false);
        Earth_info.gameObject.SetActive(false);
        Earth_Blur_panel.gameObject.SetActive(false);
        layer_info.gameObject.SetActive(true);
    }

    public void Swtch_planet()
    {
        Earth_Switch_planet.gameObject.SetActive(true);
        Earth_Close_button.gameObject.SetActive(true);
    }

 
    void Update()
    {
        
    }
}
