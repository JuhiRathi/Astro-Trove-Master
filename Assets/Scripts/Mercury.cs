using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercury : MonoBehaviour
{
    public GameObject Mercury_info;
    public GameObject Mercury_model;
    public GameObject Mercury_anim;
    public GameObject Blur_panel;
    public GameObject Back_panel;
    public GameObject Close_button;
    public GameObject Mer_Switch_planet;
    public GameObject layer_info;

    // Start is called before the first frame update
    void Start()
    {
        Mercury_model.gameObject.SetActive(true);
        Mercury_info.gameObject.SetActive(false);
        Mercury_anim.gameObject.SetActive(false);
        Blur_panel.gameObject.SetActive(false);
        Back_panel.gameObject.SetActive(false);
        Close_button.gameObject.SetActive(false);
        Mer_Switch_planet.gameObject.SetActive(false);
        layer_info.gameObject.SetActive(false);
    }


    public void mercury_info_show()
    {
        Mercury_info.gameObject.SetActive(true);
        Blur_panel.gameObject.SetActive(true);
        Back_panel.gameObject.SetActive(true);
        Close_button.gameObject.SetActive(true);

    }

    public void close_mercury_panel()
    {
        Mercury_info.gameObject.SetActive(false);
        Blur_panel.gameObject.SetActive(false);
        Back_panel.gameObject.SetActive(false);
        Close_button.gameObject.SetActive(false);
        Mer_Switch_planet.gameObject.SetActive(false);
    }

    public void mercury_show_structure()
    {
        Mercury_model.gameObject.SetActive(false);
        Mercury_anim.gameObject.SetActive(true);
        Back_panel.gameObject.SetActive(false);
        Close_button.gameObject.SetActive(false);
        Mercury_info.gameObject.SetActive(false);
        Blur_panel.gameObject.SetActive(false);
        layer_info.gameObject.SetActive(true);
    }

    public void Swtch_planet()
    {
        Mer_Switch_planet.gameObject.SetActive(true);
        Close_button.gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
