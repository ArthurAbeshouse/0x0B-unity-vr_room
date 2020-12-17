using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Loco_motion : MonoBehaviour
{
    public XRController leftray;
    public XRController rightray;
    public InputHelpers.Button Grabthings;
    public float activationThreshold = 0.1f;

    // Update is called once per frame
    void Update()
    {
        if (leftray)
        {
            leftray.gameObject.SetActive(CheckIfActivated(leftray));
        }
        if (rightray)
        {
            rightray.gameObject.SetActive(CheckIfActivated(rightray));
        }

    }

    public bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, Grabthings, out bool isActivated, activationThreshold);
        return isActivated;
    }
}
