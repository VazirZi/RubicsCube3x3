using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

// class controller for up (white) edge of cube

public class UpEdgeController : Controller
{
    // method for set parent of up array by pressing the left mouse button

    private void OnMouseDown()
    {
        controller.SetParent("upArray");
        
        if (Input.GetMouseButtonDown(0))
        {
            targetRotation *= Quaternion.AngleAxis(90f, Vector3.up);
        }

        controller.RotateArray(controller.upArray, "upArray");
        controller.ResetParent("upArray");
    }
}
