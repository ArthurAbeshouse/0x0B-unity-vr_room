using OculusSampleFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleGrab : DistanceGrabbable
{
    public Transform handler;

    public float distance;

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(Vector3.zero, Vector3.zero);

        transform.position = handler.position;
        transform.rotation = handler.rotation;

        Rigidbody rbdyhandle = handler.GetComponent<Rigidbody>();
        rbdyhandle.velocity = Vector3.zero;
        rbdyhandle.angularVelocity = Vector3.zero;
    }

    private void Update()
    {
        if (Vector3.Distance(handler.position, transform.position) > distance)
        {
            grabbedBy.ForceRelease(this);
        }
    }
}
