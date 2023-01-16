using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lunar_cyc : MonoBehaviour
{
    public GameObject Wan_Cres;
    public GameObject Wan_Cres_static;

    public GameObject Frst_Quat;
    public GameObject Frst_Quat_static;

    public GameObject Wan_Gib;
    public GameObject Wan_Gib_static;


    public GameObject Full_Moon;
    public GameObject Full_Moon_static;


    public GameObject Third_Quat;
    public GameObject Third_Quat_static;


    public GameObject Wax_Cres;
    public GameObject Wax_Cres_static;


    public GameObject Wax_Gib;
    public GameObject Wax_Gib_static;


    public GameObject New_Moon;
    public GameObject New_Moon_static;


    public GameObject Full_Orbit;


    // Start is called before the first frame update
    void Start()
    {
        Full_Orbit.gameObject.SetActive(true);
        Wan_Cres.gameObject.SetActive(false);
        Wan_Cres_static.gameObject.SetActive(false);
        Frst_Quat.gameObject.SetActive(false);
        Frst_Quat_static.gameObject.SetActive(false);
        Wan_Gib.gameObject.SetActive(false);
        Wan_Gib_static.gameObject.SetActive(false);
        Full_Moon.gameObject.SetActive(false);
        Full_Moon_static.gameObject.SetActive(false);
        Third_Quat.gameObject.SetActive(false);
        Third_Quat_static.gameObject.SetActive(false);
        Wax_Cres.gameObject.SetActive(false);
        Wax_Cres_static.gameObject.SetActive(false);
        Wax_Gib.gameObject.SetActive(false);
        Wax_Gib_static.gameObject.SetActive(false);
        New_Moon.gameObject.SetActive(false);
        New_Moon_static.gameObject.SetActive(false);
    }

    public void wanning_cres()
    {
        Full_Orbit.gameObject.SetActive(false);
        New_Moon_static.gameObject.SetActive(true);
        Wan_Cres.gameObject.SetActive(true);
        
    }
    public void frs_quat()
    {
        Full_Orbit.gameObject.SetActive(false);
        New_Moon_static.gameObject.SetActive(true);
        Wan_Cres.gameObject.SetActive(false);
        Wan_Cres_static.gameObject.SetActive(true);
        Frst_Quat.gameObject.SetActive(true);

    }
    public void wanning_gib()
    {
        Full_Orbit.gameObject.SetActive(false);
        New_Moon_static.gameObject.SetActive(true);
        Wan_Cres.gameObject.SetActive(false);
        Wan_Cres_static.gameObject.SetActive(true);
        Frst_Quat.gameObject.SetActive(false);
        Frst_Quat_static.gameObject.SetActive(true);
        Wan_Gib.gameObject.SetActive(true);

    }
    public void fll_moon()
    {
        Full_Orbit.gameObject.SetActive(false);
        New_Moon_static.gameObject.SetActive(true);
        Wan_Cres.gameObject.SetActive(false);
        Wan_Cres_static.gameObject.SetActive(true);
        Frst_Quat.gameObject.SetActive(false);
        Frst_Quat_static.gameObject.SetActive(true);
        Wan_Gib.gameObject.SetActive(false);
        Wan_Gib_static.gameObject.SetActive(true);
        Full_Moon.gameObject.SetActive(true);
    }
    public void waxing_gib()
    {
        Full_Orbit.gameObject.SetActive(false);
        New_Moon_static.gameObject.SetActive(true);
        Wan_Cres.gameObject.SetActive(false);
        Wan_Cres_static.gameObject.SetActive(true);
        Frst_Quat.gameObject.SetActive(false);
        Frst_Quat_static.gameObject.SetActive(true);
        Wan_Gib.gameObject.SetActive(false);
        Wan_Gib_static.gameObject.SetActive(true);
        Full_Moon.gameObject.SetActive(false);
        Full_Moon_static.gameObject.SetActive(true);
        Wax_Gib.gameObject.SetActive(true);
    }
    public void thrd_quat()
    {
        Full_Orbit.gameObject.SetActive(false);
        New_Moon_static.gameObject.SetActive(true);
        Wan_Cres.gameObject.SetActive(false);
        Wan_Cres_static.gameObject.SetActive(true);
        Frst_Quat.gameObject.SetActive(false);
        Frst_Quat_static.gameObject.SetActive(true);
        Wan_Gib.gameObject.SetActive(false);
        Wan_Gib_static.gameObject.SetActive(true);
        Full_Moon.gameObject.SetActive(false);
        Full_Moon_static.gameObject.SetActive(true);
        Wax_Gib.gameObject.SetActive(false);
        Wax_Gib_static.gameObject.SetActive(true);
        Third_Quat.gameObject.SetActive(true);
    }
    public void waxing_cres()
    {
        Full_Orbit.gameObject.SetActive(false);
        New_Moon_static.gameObject.SetActive(true);
        Full_Orbit.gameObject.SetActive(false);
        Wan_Cres.gameObject.SetActive(false);
        Wan_Cres_static.gameObject.SetActive(true);
        Frst_Quat.gameObject.SetActive(false);
        Frst_Quat_static.gameObject.SetActive(true);
        Wan_Gib.gameObject.SetActive(false);
        Wan_Gib_static.gameObject.SetActive(true);
        Full_Moon.gameObject.SetActive(false);
        Full_Moon_static.gameObject.SetActive(true);
        Wax_Gib.gameObject.SetActive(false);
        Wax_Gib_static.gameObject.SetActive(true);
        Third_Quat.gameObject.SetActive(false);
        Third_Quat_static.gameObject.SetActive(true);
        Wax_Cres.gameObject.SetActive(true);
    }
    public void nw_moon()
    {
        Full_Orbit.gameObject.SetActive(false);
        New_Moon_static.gameObject.SetActive(false);
        Full_Orbit.gameObject.SetActive(false);
        Wan_Cres.gameObject.SetActive(false);
        Wan_Cres_static.gameObject.SetActive(true);
        Frst_Quat.gameObject.SetActive(false);
        Frst_Quat_static.gameObject.SetActive(true);
        Wan_Gib.gameObject.SetActive(false);
        Wan_Gib_static.gameObject.SetActive(true);
        Full_Moon.gameObject.SetActive(false);
        Full_Moon_static.gameObject.SetActive(true);
        Wax_Gib.gameObject.SetActive(false);
        Wax_Gib_static.gameObject.SetActive(true);
        Third_Quat.gameObject.SetActive(false);
        Third_Quat_static.gameObject.SetActive(true);
        Wax_Cres.gameObject.SetActive(false);
        Wax_Cres_static.gameObject.SetActive(true);
        New_Moon.gameObject.SetActive(true);
    }
    void Update()
    {
        
    }
}
