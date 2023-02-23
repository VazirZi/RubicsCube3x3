using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaysController : MonoBehaviour
{
    //[SerializeField] Transform FrontRay;
    [SerializeField] private GameObject[] _upRays;
    private GameObject[] _arrayElements;

    private Vector2 firstMousePosition;
    private Vector2 secondMousePosition;
    private Vector2 currentMousePosition;
    private GameObject selectedElement;
    private Ray cameraRay;
    private int layerMask = 1 << 2;
    private RaycastHit hit;

    private void Awake()
    {
        _arrayElements = new GameObject[9];
    }

    private void Update()
    {
        cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(cameraRay, out hit) && Input.GetMouseButtonDown(0))
        {
            firstMousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            selectedElement = hit.collider.gameObject;
        }
        if (Input.GetMouseButtonUp(0))
        {
            secondMousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            currentMousePosition = new Vector2(secondMousePosition.x - firstMousePosition.x, secondMousePosition.y - firstMousePosition.y);

            string direction = FindDirection(currentMousePosition);

            if (direction == "leftSwipe")
            {
                FillArrayOfActiveEdge(_upRays, _arrayElements);
                //Debug.Log($"{selectedElement.name}, {direction}");
            }
            else if (direction == "rightSwipe")
            {
                FillArrayOfActiveEdge(_upRays, _arrayElements);
                //Debug.Log($"{selectedElement.name}, {direction}");
            }
        }
    }
    private void FillArrayOfActiveEdge(GameObject[] _upRays, GameObject[] _arrayElements)
    {
        Debug.Log("Заход в заполнение массива");

        int i = 0;

        foreach (var element in _upRays)
        {
            if (Physics.Raycast(element.transform.position, Vector3.down, out hit, 3f, layerMask))
            {
                _arrayElements[i] = hit.collider.gameObject;
                Debug.Log(_arrayElements[i]);
                i++;
            }
        }
    }

    private string FindDirection(Vector2 currentMousePosition)
    {
        string direction = string.Empty;

        if (LeftSwipe(currentMousePosition)) direction = "leftSwipe";
        else if (RightSwipe(currentMousePosition)) direction = "rightSwipe";
        
        return direction;
    }

    private bool LeftSwipe(Vector2 currentMousePosition)
    {
        return currentMousePosition.x < 0 && currentMousePosition.y < 0.5f && currentMousePosition.y > -0.5f;
    }

    private bool RightSwipe(Vector2 swipe)
    {
        return currentMousePosition.x > 0 && currentMousePosition.y < 0.5f && currentMousePosition.y > -0.5f;
    }

    private void SetParent(GameObject[] array)
    {
        foreach (var element in array)
        {
            element.transform.parent = array[4].transform;
        }
    }
}
