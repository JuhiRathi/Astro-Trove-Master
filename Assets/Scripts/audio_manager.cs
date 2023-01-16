using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_manager : MonoBehaviour
{
    public AudioSource Moon_Orbit_A;
    public AudioSource New_moon_A;
    public AudioSource Wax_Cres_A;
    public AudioSource Frs_quat_A;
    public AudioSource Wax_Gib_A;
    public AudioSource Full_moon_A;
    public AudioSource Wan_Gib_A;
    public AudioSource Thrd_quat_A;
    public AudioSource Wan_Cres_A;

    // Start is called before the first frame update
    public void Moon_Orb_A()
    {
        Moon_Orbit_A.Play();
        New_moon_A.Stop();
        Wax_Cres_A.Stop();
        Frs_quat_A.Stop();
        Wax_Gib_A.Stop();
        Full_moon_A.Stop();
        Wan_Gib_A.Stop();
        Thrd_quat_A.Stop();
        Wan_Cres_A.Stop();
    }
    public void Nw_moon_A()
    {
        Moon_Orbit_A.Stop();
        New_moon_A.Play();
        Wax_Cres_A.Stop();
        Frs_quat_A.Stop();
        Wax_Gib_A.Stop();
        Full_moon_A.Stop();
        Wan_Gib_A.Stop();
        Thrd_quat_A.Stop();
        Wan_Cres_A.Stop();
    }
    public void Wax_cre_A()
    {
        Moon_Orbit_A.Stop();
        New_moon_A.Stop();
        Wax_Cres_A.Play();
        Frs_quat_A.Stop();
        Wax_Gib_A.Stop();
        Full_moon_A.Stop();
        Wan_Gib_A.Stop();
        Thrd_quat_A.Stop();
        Wan_Cres_A.Stop();
    }
    public void Frst_qua_A()
    {
        Moon_Orbit_A.Stop();
        New_moon_A.Stop();
        Wax_Cres_A.Stop();
        Frs_quat_A.Play();
        Wax_Gib_A.Stop();
        Full_moon_A.Stop();
        Wan_Gib_A.Stop();
        Thrd_quat_A.Stop();
        Wan_Cres_A.Stop();
    }
    public void Wax_gibb_A()
    {
        Moon_Orbit_A.Stop();
        New_moon_A.Stop();
        Wax_Cres_A.Stop();
        Frs_quat_A.Stop();
        Wax_Gib_A.Play();
        Full_moon_A.Stop();
        Wan_Gib_A.Stop();
        Thrd_quat_A.Stop();
        Wan_Cres_A.Stop();
    }
    public void fll_moon_A()
    {
        Moon_Orbit_A.Stop();
        New_moon_A.Stop();
        Wax_Cres_A.Stop();
        Frs_quat_A.Stop();
        Wax_Gib_A.Stop();
        Full_moon_A.Play();
        Wan_Gib_A.Stop();
        Thrd_quat_A.Stop();
        Wan_Cres_A.Stop();
    }
    public void Wan_gibb_A()
    {
        Moon_Orbit_A.Stop();
        New_moon_A.Stop();
        Wax_Cres_A.Stop();
        Frs_quat_A.Stop();
        Wax_Gib_A.Stop();
        Full_moon_A.Stop();
        Wan_Gib_A.Play();
        Thrd_quat_A.Stop();
        Wan_Cres_A.Stop();
    }
    public void Thr_quat_A()
    {
        Moon_Orbit_A.Stop();
        New_moon_A.Stop();
        Wax_Cres_A.Stop();
        Frs_quat_A.Stop();
        Wax_Gib_A.Stop();
        Full_moon_A.Stop();
        Wan_Gib_A.Stop();
        Thrd_quat_A.Play();
        Wan_Cres_A.Stop();
    }
    public void Wan_Cresc_A()
    {
        Moon_Orbit_A.Stop();
        New_moon_A.Stop();
        Wax_Cres_A.Stop();
        Frs_quat_A.Stop();
        Wax_Gib_A.Stop();
        Full_moon_A.Stop();
        Wan_Gib_A.Stop();
        Thrd_quat_A.Stop();
        Wan_Cres_A.Play();
    }
}