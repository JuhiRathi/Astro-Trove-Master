using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ui_Buttons : MonoBehaviour
{
    
    //public Ui_Buttons Tap;


    //public GameObject Galaxy;
    
    void Start()
    {
        
        
    }
    /*public void taphere()
    {
        Galaxy.gameObject.SetActive(true);
    }*/
    public void SwitchtoMercury()
    {
        SceneManager.LoadScene("Mercury_planet");
    }
    public void SwitchtoVenus()
    {
        SceneManager.LoadScene("Venus_planet");
    }

    public void SwitchtoEarth()
    {
        SceneManager.LoadScene("Earth_planet");
    }

    public void SwitchtoMars()
    {
        SceneManager.LoadScene("Mars_planet");
    }

    public void SwitchtoJupiter()
    {
        SceneManager.LoadScene("Jupiter_planet");
    }

    public void SwitchtoSaturn()
    {
        SceneManager.LoadScene("Saturn_planet");
    }
    public void SwitchtoUranus()
    {
        SceneManager.LoadScene("Uranus_planet");
    }
    public void SwitchtoNeptune()
    {
        SceneManager.LoadScene("Neptune_planet");
    }

    public void lunar_cycle()
    {
        SceneManager.LoadScene("Lunar_cycle");
    }
    void Update()
    {

    }

}
