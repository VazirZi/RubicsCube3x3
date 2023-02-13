using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

// class controller for down (yellow) edge of cube

public class DownEdgeController : Controller
{
    // method for set parent of down array by pressing the left mouse button

    private void OnMouseDown()
    {
        controller.SetParent("downArray");
        
        if (Input.GetMouseButtonDown(0))
        {
            targetRotation *= Quaternion.AngleAxis(90f, Vector3.down);
        }

        controller.RotateArray(controller.downArray, "downArray");
        controller.ResetParent("downArray");
    }
}
