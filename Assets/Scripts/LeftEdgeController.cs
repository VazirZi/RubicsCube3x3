using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

// class controller for left (orange) edge of cube

public class LeftEdgeController : Controller
{
    // method for set parent of left array by pressing the left mouse button

    private void OnMouseDown()
    {
        controller.SetParent("leftArray");
        
        if (Input.GetMouseButtonDown(0))
        {
            targetRotation *= Quaternion.AngleAxis(90f, Vector3.left);
        }

        controller.RotateArray(controller.leftArray, "leftArray");
        controller.ResetParent("leftArray");
    }
}
