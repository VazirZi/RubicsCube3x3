using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// Данный класс реализует логику поворота любой грани куба по нажатию левой кнопки мыши.
/// </summary>

public class EdgeRotateController : MonoBehaviour
{
    #region BLOCK_OF_SERIALIZEFIELD_VARIABLES
    [SerializeField] private GameObject[] _upRays;
    [SerializeField] private GameObject[] _frontRays;
    [SerializeField] private GameObject[] _rightRays;
    [SerializeField] private GameObject[] _leftRays;
    [SerializeField] private GameObject[] _backRays;
    [SerializeField] private GameObject[] _downRays;
    [SerializeField] private GameObject[] _verticalFrontRays;
    [SerializeField] private GameObject[] _horizontalFrontRays;
    [SerializeField] private GameObject[] _verticalRightRays;
    [SerializeField] private GameObject[] _horizontalRightRays;
    [SerializeField] private GameObject[] _verticalUpRays;
    [SerializeField] private GameObject[] _horizontalUpRays;
    [SerializeField] private GameObject[] _verticalLeftRays;
    [SerializeField] private GameObject[] _horizontalLeftRays;
    [SerializeField] private GameObject[] _verticalBackRays;
    [SerializeField] private GameObject[] _horizontalBackRays;
    [SerializeField] private GameObject[] _verticalDownRays;
    [SerializeField] private GameObject[] _horizontalDownRays;
    [SerializeField] private GameObject EdgesRotationController;
    [SerializeField] private GameObject ParentCube;
    [SerializeField] private GameObject CenterOfCube;

    #endregion

    #region BLOCK_OF_OTHER_VARIABLES

    private GameObject[] _activeEdge;
    private GameObject[] _activeCenterEdge;
    private GameObject selectedElement;
    private GameObject parentForRotation;
    private GameObject temporaryParent;
    private Vector3 raysDirection;
    private Vector3 upRayDirection;
    private Vector3 downRayDirection;
    private Vector3 frontRayDirection;
    private Vector3 backRayDirection;
    private Vector3 rightRayDirection;
    private Vector3 leftRayDirection;
    private Vector2 firstMousePosition;
    private Vector2 secondMousePosition;
    private Vector2 currentMousePosition;
    private string nameSelectedElement;
    private string swipeDirection;
    private string nameOfActiveEdge;
    private Ray cameraRay;
    private RaycastHit hit;
    private LayerMask layerMask;
    private Quaternion targetRotation;

    #endregion
    private void Start()
    {
        _activeEdge = new GameObject[9];
        _activeCenterEdge = new GameObject[12];

        raysDirection = new Vector3(0, 0, 0);
        
        upRayDirection = -Vector3.up;
        downRayDirection = Vector3.up;
        frontRayDirection = Vector3.forward;
        backRayDirection = -Vector3.forward;
        leftRayDirection = Vector3.right;
        rightRayDirection = -Vector3.right;

        layerMask = 1 << 3;
    } 
    void Update()
    {
        cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        FindDirectionOfSwipe();

        if (parentForRotation != null && targetRotation != new Quaternion(0, 0, 0, 0))
        {
            parentForRotation.transform.localRotation = Quaternion.RotateTowards(parentForRotation.transform.localRotation, Quaternion.Euler(targetRotation.x, targetRotation.y, targetRotation.z), 370f * Time.deltaTime);
        }
    }
    private void FindDirectionOfSwipe()
    {
        if(Input.GetMouseButtonDown(0) && Calculation.wasRightMouseClick == false && Calculation.wasLeftMouseClick == false && Calculation.countOfLeftMouseButtonClick == 0)
        {
            Calculation.wasLeftMouseClick = true;

            firstMousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            if (Physics.Raycast(cameraRay, out hit, 100f, layerMask))
            {
                selectedElement = hit.collider.gameObject;
                nameSelectedElement = Calculation.FindNameOfObjectByHisPosition(selectedElement);
            }
        }

        if (Input.GetMouseButtonUp(0) && Calculation.wasLeftMouseClick == true && Calculation.countOfLeftMouseButtonClick == 0)
        {
            Calculation.countOfLeftMouseButtonClick = 1;

            secondMousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            currentMousePosition = new Vector2(secondMousePosition.x - firstMousePosition.x, secondMousePosition.y - firstMousePosition.y);
            currentMousePosition.Normalize();

            swipeDirection = Calculation.FindDirectionOfSwipe(currentMousePosition, nameSelectedElement);
            nameOfActiveEdge = Calculation.FindActiveEdge(nameSelectedElement, swipeDirection);
            raysDirection = Calculation.FindRaysDirecrion(nameOfActiveEdge);
            
            switch (nameOfActiveEdge)
            {
                case "upEdge": FillActiveEdgeArray(_upRays, raysDirection) ; break;
                case "frontEdge": FillActiveEdgeArray(_frontRays, raysDirection) ; break;
                case "rightEdge": FillActiveEdgeArray(_rightRays, raysDirection) ; break;
                case "leftEdge": FillActiveEdgeArray(_leftRays, raysDirection) ; break;
                case "backEdge": FillActiveEdgeArray(_backRays, raysDirection) ; break;
                case "downEdge": FillActiveEdgeArray(_downRays, raysDirection) ; break;
                case "frontVerticalEdge" : FillActiveHorizontalOrVerticalEdgeArray(_verticalUpRays, _verticalFrontRays, _verticalDownRays, _verticalBackRays, 
                                                                                   upRayDirection, frontRayDirection, downRayDirection, backRayDirection) ; break;
                case "rightVerticalEdge" : FillActiveHorizontalOrVerticalEdgeArray(_verticalRightRays, _horizontalUpRays, _verticalLeftRays, _horizontalDownRays, 
                                                                                   rightRayDirection, upRayDirection, leftRayDirection, downRayDirection) ; break;
                case "horizontalEdge" : FillActiveHorizontalOrVerticalEdgeArray(_horizontalFrontRays, _horizontalRightRays, _horizontalBackRays, _horizontalLeftRays, 
                                                                                   frontRayDirection, rightRayDirection, backRayDirection, leftRayDirection) ; break;
                default: Calculation.countOfLeftMouseButtonClick = 0; break;    // выполняется, если был клик без свайпа
            }
        }
    }
    private void FillActiveEdgeArray(GameObject[] raysArray, Vector3 rayDirection)
    {
        int i = 0;

        foreach (var ray in raysArray)
        {
            if (Physics.Raycast(ray.transform.position, rayDirection, out hit, 3f))
            {
                _activeEdge[i] = hit.collider.gameObject;
                i++;
            }
        }

        SetParentInActiveEdge(_activeEdge);
    }
    private void FillActiveHorizontalOrVerticalEdgeArray(GameObject[] firstRaysArray, GameObject[] secondRaysArray, GameObject[] thridRaysArray, GameObject[] fourRaysArray, 
                                                         Vector3 firstRayDirection, Vector3 secondRayDirection, Vector3 thridRayDirection, Vector3 fourRayDirection)
    {
        int i = 0;

        foreach (var ray in firstRaysArray)
        {
            if (Physics.Raycast(ray.transform.position, firstRayDirection, out hit, 3f))
            {
                _activeCenterEdge[i] = hit.collider.gameObject;
                i++;
            } 
        }
        foreach (var ray in secondRaysArray)
        {
            if (Physics.Raycast(ray.transform.position, secondRayDirection, out hit, 3f))
            {
                _activeCenterEdge[i] = hit.collider.gameObject;
                i++;
            } 
        }
        foreach (var ray in thridRaysArray)
        {
            if (Physics.Raycast(ray.transform.position, thridRayDirection, out hit, 3f))
            {
                _activeCenterEdge[i] = hit.collider.gameObject;
                i++;
            } 
        }
        foreach (var ray in fourRaysArray)
        {
            if (Physics.Raycast(ray.transform.position, fourRayDirection, out hit, 3f))
            {
                _activeCenterEdge[i] = hit.collider.gameObject;
                i++;
            } 
        }

        SetParentInActiveEdge(_activeCenterEdge);
    }
    private void SetParentInActiveEdge(GameObject[] _activeEdge)
    {
        targetRotation = Calculation.SetRotationForEdge(nameOfActiveEdge, swipeDirection);
        
        parentForRotation = EdgesRotationController;

        if (nameOfActiveEdge == "frontVerticalEdge" || nameOfActiveEdge == "rightVerticalEdge" || nameOfActiveEdge == "horizontalEdge")
            temporaryParent = CenterOfCube;
        else
            temporaryParent = _activeEdge[4];

        foreach (var element in _activeEdge)
        {
            element.transform.parent = temporaryParent.transform;
        }

        temporaryParent.transform.parent = parentForRotation.transform;

        SetDefaultValues(_activeEdge);
    }
    private async void SetDefaultValues(GameObject[] _activeEdge)
    {
        await Task.Delay(TimeSpan.FromSeconds(0.3));

        foreach (var element in _activeEdge)
        {
            element.transform.parent = ParentCube.transform;
        }

        parentForRotation = null;
        targetRotation = new Quaternion(0, 0, 0, 0);
        EdgesRotationController.transform.rotation = Quaternion.Euler(0, 0, 0);

        Calculation.wasLeftMouseClick = false;
        Calculation.countOfLeftMouseButtonClick = 0;
    }
}