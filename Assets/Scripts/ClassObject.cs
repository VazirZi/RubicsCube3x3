using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

// a class, that performs logic for all cube objects 

public class ClassObject : MonoBehaviour
{
    //---- front edge -----

    private GameObject frontLeftUp;
    private GameObject frontMiddleUp;
    private GameObject frontRightUp;

    private GameObject frontLeftMiddle;
    private GameObject frontCenter;
    private GameObject frontRightMiddle;

    private GameObject frontLeftDown;
    private GameObject frontMiddleDown;
    private GameObject frontRightDown;  

    //------ right edge ----------

    private GameObject rightLeftUp;
    private GameObject rightMiddleUp;
    private GameObject rightRightUp;

    private GameObject rightLeftMiddle;
    private GameObject rightCenter;
    private GameObject rightRightMiddle;

    private GameObject rightLeftDown;
    private GameObject rightMiddleDown;
    private GameObject rightRightDown;

    //------ left edge -----------

    private GameObject leftLeftUp;
    private GameObject leftMiddleUp;
    private GameObject leftRightUp;

    private GameObject leftLeftMiddle;
    private GameObject leftCenter;
    private GameObject leftRightMiddle;

    private GameObject leftLeftDown;
    private GameObject leftMiddleDown;
    private GameObject leftRightDown;

    //------ up edge ---------

    private GameObject upLeftUp;
    private GameObject upMiddleUp;
    private GameObject upRightUp;

    private GameObject upLeftMiddle;
    private GameObject upCenter;
    private GameObject upRightMiddle;

    private GameObject upLeftDown;
    private GameObject upMiddleDown;
    private GameObject upRightDown;

    //------ down edge ----------

    private GameObject downLeftUp;
    private GameObject downMiddleUp;
    private GameObject downRightUp;

    private GameObject downLeftMiddle;
    private GameObject downCenter;
    private GameObject downRightMiddle;

    private GameObject downLeftDown;
    private GameObject downMiddleDown;
    private GameObject downRightDown;

    //------ back edge ---------

    private GameObject backLeftUp;
    private GameObject backMiddleUp;
    private GameObject backRightUp;

    private GameObject backLeftMiddle;
    private GameObject backCenter;
    private GameObject backRightMiddle;

    private GameObject backLeftDown;
    private GameObject backMiddleDown;
    private GameObject backRightDown;

    // arrays of face objects

    public GameObject[ , ] frontArray;
    public GameObject[ , ] rightArray;
    public GameObject[ , ] leftArray;
    public GameObject[ , ] upArray;
    public GameObject[ , ] downArray;
    public GameObject[ , ] backArray;

    // logical indicators of face rotation

    private bool isFrontRotate;
    private bool isRightRotate;
    private bool isLeftRotate;
    private bool isUpRotate;
    private bool isDownRotate;
    private bool isBackRotate;

    private GameObject mainCube;

    void Awake()
    {
        // find all elements

        mainCube = GameObject.Find("Cube");

        // front edge

        frontLeftUp = GameObject.Find("FrontLeftUp");
        frontMiddleUp = GameObject.Find("FrontMiddleUp");
        frontRightUp = GameObject.Find("FrontRightUp");

        frontLeftMiddle = GameObject.Find("FrontLeftMiddle");
        frontCenter = GameObject.Find("FrontCenter");
        frontRightMiddle = GameObject.Find("FrontRightMiddle");

        frontLeftDown = GameObject.Find("FrontLeftDown");
        frontMiddleDown = GameObject.Find("FrontMiddleDown");
        frontRightDown = GameObject.Find("FrontRightDown");
    
        // right edge

        rightLeftUp = GameObject.Find("FrontRightUp");
        rightMiddleUp = GameObject.Find("MiddleRightUp");
        rightRightUp = GameObject.Find("BackRightUp");

        rightLeftMiddle = GameObject.Find("FrontRightMiddle");
        rightCenter = GameObject.Find("MiddleRightMiddle");
        rightRightMiddle = GameObject.Find("BackRightMiddle");

        rightLeftDown = GameObject.Find("FrontRightDown");
        rightMiddleDown = GameObject.Find("MiddleRightDown");
        rightRightDown = GameObject.Find("BackRightDown");

        // left edge

        leftLeftUp = GameObject.Find("BackLeftUp");
        leftMiddleUp = GameObject.Find("MiddleLeftUp");
        leftRightUp = GameObject.Find("FrontLeftUp");

        leftLeftMiddle = GameObject.Find("BackLeftMiddle");
        leftCenter = GameObject.Find("MiddleLeftMiddle");
        leftRightMiddle = GameObject.Find("FrontLeftMiddle");

        leftLeftDown = GameObject.Find("BackLeftDown");
        leftMiddleDown = GameObject.Find("MiddleLeftDown");
        leftRightDown = GameObject.Find("FrontLeftDown");

        // up edge

        upLeftUp = GameObject.Find("BackLeftUp");
        upMiddleUp = GameObject.Find("BackMiddleUp");
        upRightUp = GameObject.Find("BackRightUp");

        upLeftMiddle = GameObject.Find("MiddleLeftUp");
        upCenter = GameObject.Find("MiddleMiddleUp");
        upRightMiddle = GameObject.Find("MiddleRightUp");

        upLeftDown = GameObject.Find("FrontLeftUp");
        upMiddleDown = GameObject.Find("FrontMiddleUp");
        upRightDown = GameObject.Find("FrontRightUp");

        // down edge

        downLeftUp = GameObject.Find("FrontLeftDown");
        downMiddleUp = GameObject.Find("FrontMiddleDown");
        downRightUp = GameObject.Find("FrontRightDown");

        downLeftMiddle = GameObject.Find("MiddleLeftDown");
        downCenter = GameObject.Find("MiddleMiddleDown");
        downRightMiddle = GameObject.Find("MiddleRightDown");

        downLeftDown = GameObject.Find("BackLeftDown");
        downMiddleDown = GameObject.Find("BackMiddleDown");
        downRightDown = GameObject.Find("BackRightDown");

        // back edge

        backLeftUp = GameObject.Find("BackRightUp");
        backMiddleUp = GameObject.Find("BackMiddleUp");
        backRightUp = GameObject.Find("BackLeftUp");

        backLeftMiddle = GameObject.Find("BackRightMiddle");
        backCenter = GameObject.Find("BackCenter");
        backRightMiddle = GameObject.Find("BackLeftMiddle");

        backLeftDown = GameObject.Find("BackRightDown");
        backMiddleDown = GameObject.Find("BackMiddleDown");
        backRightDown = GameObject.Find("BackLeftDown");


        // filling in all arrays in a strictly defined order

        frontArray = new GameObject[3, 3]
        {
            { frontLeftUp, frontMiddleUp, frontRightUp },
            { frontLeftMiddle, frontCenter, frontRightMiddle },
            { frontLeftDown, frontMiddleDown, frontRightDown }
        };

        rightArray = new GameObject[3, 3]
        {
            { rightLeftUp, rightMiddleUp, rightRightUp },
            { rightLeftMiddle, rightCenter, rightRightMiddle },
            { rightLeftDown, rightMiddleDown, rightRightDown }
        };

        leftArray = new GameObject[3, 3]
        {
            { leftLeftUp, leftMiddleUp, leftRightUp },
            { leftLeftMiddle, leftCenter, leftRightMiddle },
            { leftLeftDown, leftMiddleDown, leftRightDown }
        };

        upArray = new GameObject[3, 3]
        {
            { upLeftUp, upMiddleUp, upRightUp },
            { upLeftMiddle, upCenter, upRightMiddle },
            { upLeftDown, upMiddleDown, upRightDown }
        };

        downArray = new GameObject[3, 3]
        {
            { downLeftUp, downMiddleUp, downRightUp },
            { downLeftMiddle, downCenter, downRightMiddle },
            { downLeftDown, downMiddleDown, downRightDown }
        };

        backArray = new GameObject[3, 3]
        {
            { backLeftUp, backMiddleUp, backRightUp },
            { backLeftMiddle, backCenter, backRightMiddle },
            { backLeftDown, backMiddleDown, backRightDown }
        };  
    }

    // the method of turing the face clockwise

    public void RotateArray(GameObject[ , ] array, string name)
    {
        var temp = array[0, 0];     // variable to replace

        array[0, 0] = array[2, 0];
        array[2, 0] = array[2, 2];
        array[2, 2] = array[0, 2];
        array[0, 2] = temp;

        temp = array[1, 0];

        array[1, 0] = array[2, 1];
        array[2, 1] = array[1, 2];
        array[1, 2] = array[0, 1];
        array[0, 1] = temp;

        switch (name)
        {
            case "frontArray":
            {
                isFrontRotate = true;

                TurnUpArray();
                TurnRightArray();
                TurnDownArray();
                TurnLeftArray();

                isFrontRotate = false;
                break;
            }
            case "rightArray":
            {
                isRightRotate = true;

                TurnUpArray();
                TurnBackArray();
                TurnDownArray();
                TurnFrontArray();

                isRightRotate = false;
                break;
            }
            case "leftArray":
            {
                isLeftRotate = true; 

                TurnUpArray();
                TurnFrontArray(); 
                TurnDownArray();
                TurnBackArray();

                isLeftRotate = false;
                break;
            }
            case "upArray":
            {
                isUpRotate = true; 

                TurnBackArray();
                TurnRightArray();
                TurnFrontArray();
                TurnLeftArray();

                isUpRotate = false;
                break;
            }
            case "downArray":
            {
                isDownRotate = true;

                TurnFrontArray();
                TurnRightArray();
                TurnBackArray();
                TurnLeftArray();

                isDownRotate = false;
                break;
            }
            case "backArray":
            {
                isBackRotate = true; 

                TurnUpArray();
                TurnLeftArray();
                TurnDownArray();
                TurnRightArray();

                isBackRotate = false;
                break;
            }
        }
    }

    // the method of turing the frontal face

    private void TurnFrontArray()
    {
        if (isUpRotate)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                frontArray[j, i] = upArray[k, i];
            }
        }
        else if (isRightRotate)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                frontArray[i, k] = rightArray[i, j];
            }
        }
        else if (isLeftRotate)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                frontArray[i, j] = leftArray[i, k];
            }
        }
        else if (isDownRotate)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                frontArray[k, i] = downArray[j, i];
            }
        }
    }

    // the method of turing the right face

    private void TurnRightArray()
    {
        if (isFrontRotate)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                rightArray[i, j] = frontArray[i, k];
            }
        }
        else if (isBackRotate)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                rightArray[i, k] = backArray[i, j];
            }
        }
        else if (isUpRotate)
        {
            int j = 0;
            int k = 2;
            int t = 2;

            for (int i = 0; i < 3; i++)
            {
                rightArray[j, i] = upArray[t, k];
                t--;
            }
        }
        else if (isDownRotate)
        {
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                rightArray[k, i] = downArray[i, k];
            }
        }
    }

    // the method of turing the left face

    private void TurnLeftArray()
    {
        if (isFrontRotate)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                leftArray[i, k] = frontArray[i, j];
            }
        }
        else if (isBackRotate)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                leftArray[i, j] = backArray[i, k];
            }
        }
        else if (isUpRotate)
        {
            int j = 0;

            for (int i = 0; i < 3; i++)
            {
                leftArray[j, i] = upArray[i, j];
            }
        }
        else if (isDownRotate)
        {
            int j = 0;
            int k = 2;
            int t = 2;

            for (int i = 0; i < 3; i++)
            {
                leftArray[k, i] = downArray[t, j];
                t--;
            }
        }
    }

    // the method of turing the up face

    private void TurnUpArray()
    {
        if (isFrontRotate)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                upArray[k, i] = frontArray[j, i];
            }
        }
        else if (isBackRotate)
        {
            int j = 0;
            int t = 2;

            for (int i = 0; i < 3; i++)
            {
                upArray[j, i] = backArray[j, t];
                t--;
            }
        }
        else if (isRightRotate)
        {
            int j = 0;
            int k = 2;
            int t = 2;

            for (int i = 0; i < 3; i++)
            {
                upArray[i, k] = rightArray[j, t];
                t--;
            }
        }
        else if (isLeftRotate)
        {
            int j = 0;

            for (int i = 0; i < 3; i++)
            {
                upArray[i, j] = leftArray[j, i];
            }
        }
    }

    // the method of turing the down face

    private void TurnDownArray()
    {
        if (isFrontRotate)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                downArray[j, i] = frontArray[k, i];
            }
        }
        else if (isBackRotate)
        {
            int k = 2;
            int t = 2;

            for (int i = 0; i < 3; i++)
            {
                downArray[k, i] = backArray[k, t];
                t--;
            }
        }
        else if (isRightRotate)
        {
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                downArray[i, k] = rightArray[k, i];
            }
        }
        else if (isLeftRotate)
        {
            int j = 0;
            int k = 2;
            int t = 2;

            for (int i = 0; i < 3; i++)
            {
                downArray[i, j] = leftArray[k, t];
                t--;
            }
        }
    }

    // the method of turing the back face

    private void TurnBackArray()
    {
        if (isUpRotate)
        {
            int j = 0;
            int t = 2;

            for (int i = 0; i < 3; i++)
            {
                backArray[j, i] = upArray[j, t];
                t--;
            }
        }
        else if (isLeftRotate)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                backArray[i, k] = leftArray[i, j];
            }
        }
        else if (isRightRotate)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                backArray[i, j] = rightArray[i, k];
            }
        }
        else if (isDownRotate)
        {
            int k = 2;
            int t = 2;

            for (int i = 0; i < 3; i++)
            {
                backArray[k, i] = downArray[k, t];
                t--;
            }
        }
    }

    // parent installation method

    public void SetParent(string name)
    {
        switch (name)
        {
            case "frontArray":
            {
                foreach (var obj in frontArray)
                {
                    obj.transform.parent = frontCenter.transform;
                } 
                break;
            }
            case "rightArray":
            {
                foreach (var obj in rightArray)
                {
                    obj.transform.parent = rightCenter.transform;
                } 
                break;
            }
            case "upArray":
            {
                foreach (var obj in upArray)
                {
                    obj.transform.parent = upCenter.transform;
                }
                break;
            }
            case "leftArray":
            {
                foreach (var obj in leftArray)
                {
                    obj.transform.parent = leftCenter.transform;
                }
                break;
            }
            case "backArray":
            {
                foreach (var obj in backArray)
                {
                    obj.transform.parent = backCenter.transform;
                }
                break;
            }
            case "downArray":
            {
                foreach (var obj in downArray)
                {
                    obj.transform.parent = downCenter.transform;
                }
                break;
            }
        }
    }

    // parent reset method

    public async Task ResetParent(string name)
    {
        await Task.Delay(TimeSpan.FromSeconds(0.9f));   // waiting for the completion of the face rotation

        switch (name)
        {
            case "frontArray":
            {
                foreach (var obj in frontArray)
                {
                    obj.transform.parent = mainCube.transform;
                } 
                break;
            }
            case "rightArray":
            {
                foreach (var obj in rightArray)
                {
                    obj.transform.parent = mainCube.transform;
                } 
                break;
            }
            case "upArray":
            {
                foreach (var obj in upArray)
                {
                    obj.transform.parent = mainCube.transform;
                }
                break;
            }
            case "leftArray":
            {
                foreach (var obj in leftArray)
                {
                    obj.transform.parent = mainCube.transform;
                }
                break;
            }
            case "backArray":
            {
                foreach (var obj in backArray)
                {
                    obj.transform.parent = mainCube.transform;
                }
                break;
            }
            case "downArray":
            {
                foreach (var obj in downArray)
                {
                    obj.transform.parent = mainCube.transform;
                }
                break;
            }
        }
    }
}