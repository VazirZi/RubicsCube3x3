using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// a class that implements the logic of rotating the entire cube

public class RotateCube : MonoBehaviour
{
    private Vector2 firstMousePosition;
    private Vector2 secondMousePosition;

    Vector2 currentMousePosition;

    public GameObject target;
    
    private void Update()
    {
        SwipeController();

        if (transform.rotation != target.transform.rotation)
        {
            var step = 100f * Time.deltaTime;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, target.transform.rotation, step);
        }
    }

    // a method that determines the rotation of the cube
    // relative to the start and end position of the mouse

    private void SwipeController()
    {
        if (Input.GetMouseButtonDown(1))
        {
            firstMousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }

        if (Input.GetMouseButtonUp(1))
        {
            secondMousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            currentMousePosition = new Vector2(secondMousePosition.x - firstMousePosition.x, secondMousePosition.y - firstMousePosition.y);

            currentMousePosition.Normalize();

            if (LeftSwipe(currentMousePosition))
            {
                target.transform.Rotate(0, 90, 0, Space.World);
            }
            else if (RightSwipe(currentMousePosition))
            {
                target.transform.Rotate(0, -90, 0, Space.World);
            }
            else if (UpLeftSwipe(currentMousePosition))
            {
                target.transform.Rotate(0, 0, 90, Space.World);
            }
            else if (UpRightSwipe(currentMousePosition))
            {
                target.transform.Rotate(90, 0, 0, Space.World); 
            }
            else if (DownLeftSwipe(currentMousePosition))
            {
                target.transform.Rotate(-90, 0, 0, Space.World); 
            }
            else if (DownRightSwipe(currentMousePosition))
            {
                target.transform.Rotate(0, 0, -90, Space.World); 
            }
        }
    }

    private bool LeftSwipe(Vector2 swipe)
    {
        return swipe.x < 0 && swipe.y < 0.5f && swipe.y > -0.5f;
    }

    private bool RightSwipe(Vector2 swipe)
    {
        return swipe.x > 0 && swipe.y < 0.5f && swipe.y > -0.5f;
    }

    private bool UpLeftSwipe(Vector2 swipe)
    {
        return swipe.x < 0 && swipe.y > 0.5f;
    }

    private bool UpRightSwipe(Vector2 swipe)
    {
        return swipe.x > 0 && swipe.y > 0.5f;
    }

    private bool DownLeftSwipe(Vector2 swipe)
    {
        return swipe.x < 0 && swipe.y < 0;
    }

    private bool DownRightSwipe(Vector2 swipe)
    {
        return swipe.x > 0 && swipe.y < 0;
    }
}