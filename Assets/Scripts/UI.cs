using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{

    public void playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private void Start()
    {
/*        mercury_model.gameObject.SetActive(true);
        mercury_info.gameObject.SetActive(false);
        mercury_struc.gameObject.SetActive(false);
        mercury_close_panel.gameObject.SetActive(false);*/
    }

    
/*    public void mercury()
    {
        SceneManager.LoadScene("New_scene");
    }*/
/*    public void mercury_structure()
    {
        mercury_struc.gameObject.SetActive(true);
        mercury_model.gameObject.SetActive(false);
    }
    public void mercury_infor()
    {
        mercury_info.gameObject.SetActive(true);
    }
    public void mercury_panel()
    {
        mercury_close_panel.gameObject.SetActive(false);
    }
*/

    public void Sol_Sys()
    {
        SceneManager.LoadScene("Main_scene");

    }
    public void Quitgame()
    {
        Application.Quit();
    }
}
