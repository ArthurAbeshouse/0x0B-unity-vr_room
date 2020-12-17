using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_switch : MonoBehaviour
{
    public GameObject Particles;

    public bool On = false;

    // Update is called once per frame
    /*void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.Touch) || OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger, OVRInput.Controller.Touch))
        {
            On = !On;
        }
    }*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 11)
        {
            On = !On;
            if (On)
            {
                Particles.SetActive(true);
            }
            else
            {
                Particles.SetActive(false);
            }
        }
    }
}
