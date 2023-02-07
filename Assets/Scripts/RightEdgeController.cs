using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightEdgeController : ClassObject
{
    [SerializeField] GameObject Controller;

    public float speed = 100f;

    Quaternion targetRotation;

    void Start()
    {
        targetRotation = transform.rotation;
    }

    void Update()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime * speed);
    }

    void OnMouseDown()
    {
        SetParent("rightArray");

        if (Input.GetMouseButtonDown(0))
        {
            targetRotation *= Quaternion.AngleAxis(90f, Vector3.right);
        }

        RotateArray(rightArray, "rightArray");
    }
}
