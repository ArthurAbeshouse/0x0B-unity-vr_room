using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Door : MonoBehaviour
{
    public GameObject Door;

    private Animator anim;

    // private OVRGrabbable ovrGr;

    //public OVRInput.RawButton shoot;

    public bool Open = false;

    private bool isTouched = false;

    private bool isGrabbed = false;

    private void Start()
    {
        anim = Door.GetComponent<Animator>();
        //ovrGr = GetComponent<OVRGrabbable>();
        //isPressed = true;
    }

    void Update()
    {
        //if(ovrGr.isGrabbed && OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, ovrGr.grabbedBy.GetController()))
        //OVRInput.Update();

        //if (ovrGr.isGrabbed && OVRInput.Get(shoot, ovrGr.grabbedBy.GetController()))
        if (isTouched && (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger) || OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger)))
        {
            Pressed();
            isGrabbed = true;
        }
        if (isGrabbed && (OVRInput.GetUp(OVRInput.Button.PrimaryHandTrigger) || OVRInput.GetUp(OVRInput.Button.SecondaryHandTrigger)))
        {
            isGrabbed = false;
            isTouched = false;
        }

        // OVRInput.FixedUpdate();
    }

    void Pressed()
    {
        Open = !Open;
        anim.SetBool("character_nearby", !Open);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            isTouched = true;
        }
    }

 /*  private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            isTouched = true;
        }
    }*/

  /*  private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            isTouched = false;
        }
    }*/

    /* void openDoor(bool isOpen)
     {
         if (Open)
         {
             anim.SetBool("character_nearby", true);
         }
         else
         {
             anim.SetBool("character_nearby", false);
         }
     } */




    /* private void OnTriggerEnter(Collider other)
     {
         //if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.Touch) || OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger, OVRInput.Controller.Touch))
            if (ovrGr.isGrabbed)
            {

                Open = !Open;
                if (Open)
                {
                    anim.SetBool("character_nearby", true);
                }
                else
                {
                    anim.SetBool("character_nearby", false);
                }
         if (OVRInput.GetDown(OVRInput.RawButton.LHandTrigger) || OVRInput.GetDown(OVRInput.RawButton.RHandTrigger))
         {
             if (other.gameObject.layer == 9)
             {
                 Open = !Open;
                 if (Open)
                 {
                     anim.SetBool("character_nearby", true);
                 }
                 else
                 {
                     anim.SetBool("character_nearby", false);
                 }
             }
         }

     }*/
}