using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Door_Backup : MonoBehaviour
{
    public GameObject Door;

    private Animator anim;

    private OVRGrabbable ovrGr;

    //public OVRInput.RawButton shoot;

    public bool Open = false;

    // public bool isPressed;

    private void Start()
    {
        anim = Door.GetComponent<Animator>();
        ovrGr = GetComponent<OVRGrabbable>();
        //isPressed = true;
    }

    /*void Update()
    {
        //if(ovrGr.isGrabbed && OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, ovrGr.grabbedBy.GetController()))
        OVRInput.Update();

        //if (ovrGr.isGrabbed && OVRInput.Get(shoot, ovrGr.grabbedBy.GetController()))
        if (OVRInput.Get(shoot, ovrGr.grabbedBy.GetController()))
        {
            if (isPressed)
                return;

            isPressed = true;

            if (isPressed)
            {
                Pressed();
            }

            Invoke("Reset", 1.5f);
        }
    }*/

    /*  void Pressed()
      {

          Open = !Open;
          anim.SetBool("character_nearby", !Open);
      }

      void Reset()
      {
          isPressed = false;
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




    private void OnTriggerEnter(Collider other)
    {
        //if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.Touch) || OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger, OVRInput.Controller.Touch))
        /*   if (ovrGr.isGrabbed)
           {

               Open = !Open;
               if (Open)
               {
                   anim.SetBool("character_nearby", true);
               }
               else
               {
                   anim.SetBool("character_nearby", false);
               }*/
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

    }
}
