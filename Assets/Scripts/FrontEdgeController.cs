using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontEdgeController : MonoBehaviour
{
    public float speed = 100f;

    Quaternion targetRotation;

    ClassObject classO;

    void Start()
    {
        classO = new ClassObject();
        targetRotation = transform.rotation;
        classO.GetAllElement();
    }

    void Update()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime * speed);
    }

    void OnMouseDown()
    {
        classO.SetParent("frontArray", ref classO.frontArray);
        
        if (Input.GetMouseButtonDown(0))
        {
            targetRotation *= Quaternion.AngleAxis(90f, Vector3.back);
        }
        classO.RotateArray(ref classO.frontArray, "frontArray");
    }
}