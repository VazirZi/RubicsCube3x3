using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

// class controller for right (red) edge of cube

public class RightEdgeController : Controller
{
    // method for set parent of right array by pressing the left mouse button

    private void OnMouseDown()
    {
        controller.SetParent("rightArray");

        if (Input.GetMouseButtonDown(0))
        {
            targetRotation *= Quaternion.AngleAxis(90f, Vector3.right);
        }

        controller.RotateArray(controller.rightArray, "rightArray");
        controller.ResetParent("rightArray");
    }
}
