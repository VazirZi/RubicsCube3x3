using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

// class controller for front (green) edge of cube

public class FrontEdgeController : Controller
{
    // method for set parent of front array by pressing the left mouse button

    private void OnMouseDown()
    {
        controller.SetParent("frontArray");

        if (Input.GetMouseButtonDown(0))
        {
            targetRotation *= Quaternion.AngleAxis(90f, Vector3.back);
        }

        controller.RotateArray(controller.frontArray, "frontArray");
        controller.ResetParent("frontArray");
    }
}