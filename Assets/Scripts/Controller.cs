using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// an abstract class containing common logic for all faces (edge controllers) 

public abstract class Controller : MonoBehaviour
{
    [SerializeField] protected ClassObject controller;
    [SerializeField] protected GameObject targetCube;
    
    public float speed = 210f;
    protected Quaternion targetRotation;

    protected void Start()
    {
        targetRotation = targetCube.transform.rotation;
    }

    protected void Update()
    {
        transform.localRotation = Quaternion.RotateTowards(transform.localRotation, targetRotation, Time.deltaTime * speed);

    }
}
