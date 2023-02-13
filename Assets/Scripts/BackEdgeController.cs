using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

// class controller for back (blue) edge of cube

public class BackEdgeController : Controller
{
    // method for set parent of back array by pressing the left mouse button

    private void OnMouseDown()
    {
        controller.SetParent("backArray");
        
        if (Input.GetMouseButtonDown(0))
        {
            targetRotation *= Quaternion.AngleAxis(90f, Vector3.forward);
        }

        controller.RotateArray(controller.backArray, "backArray");
        controller.ResetParent("backArray");
    }
}