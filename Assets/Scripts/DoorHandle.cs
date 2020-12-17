using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHandle : MonoBehaviour
{
    public Transform target;
    Rigidbody rbdy;

    // Start is called before the first frame update
    void Start()
    {
        rbdy = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rbdy.MovePosition(target.transform.position);
    }
}
