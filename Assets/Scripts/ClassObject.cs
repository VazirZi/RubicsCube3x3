using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassObject : MonoBehaviour
{
    //---- ФРОНТАЛЬНАЯ ГРАНЬ -----

    private GameObject frontLeftUp;
    private GameObject frontMiddleUp;
    private GameObject frontRightUp;

    private GameObject frontLeftMiddle;
    private GameObject frontCenter;
    private GameObject frontRightMiddle;

    private GameObject frontLeftDown;
    private GameObject frontMiddleDown;
    private GameObject frontRightDown;  

    //------ ПРАВАЯ ГРАНЬ ----------

    private GameObject rightLeftUp;
    private GameObject rightMiddleUp;
    private GameObject rightRightUp;

    private GameObject rightLeftMiddle;
    private GameObject rightCenter;
    private GameObject rightRightMiddle;

    private GameObject rightLeftDown;
    private GameObject rightMiddleDown;
    private GameObject rightRightDown;

    //------ ЛЕВАЯ ГРАНЬ -----------

    private GameObject leftLeftUp;
    private GameObject leftMiddleUp;
    private GameObject leftRightUp;

    private GameObject leftLeftMiddle;
    private GameObject leftCenter;
    private GameObject leftRightMiddle;

    private GameObject leftLeftDown;
    private GameObject leftMiddleDown;
    private GameObject leftRightDown;

    //------ ВЕРХНЯЯ ГРАНЬ ---------

    private GameObject upLeftUp;
    private GameObject upMiddleUp;
    private GameObject upRightUp;

    private GameObject upLeftMiddle;
    private GameObject upCenter;
    private GameObject upRightMiddle;

    private GameObject upLeftDown;
    private GameObject upMiddleDown;
    private GameObject upRightDown;

    //------ НИЖНЯЯ ГРАНЬ ----------

    private GameObject downLeftUp;
    private GameObject downMiddleUp;
    private GameObject downRightUp;

    private GameObject downLeftMiddle;
    private GameObject downCenter;
    private GameObject downRightMiddle;

    private GameObject downLeftDown;
    private GameObject downMiddleDown;
    private GameObject downRightDown;

    //------ ЗАДНЯЯ ГРАНЬ ---------

    private GameObject backLeftUp;
    private GameObject backMiddleUp;
    private GameObject backRightUp;

    private GameObject backLeftMiddle;
    private GameObject backCenter;
    private GameObject backRightMiddle;

    private GameObject backLeftDown;
    private GameObject backMiddleDown;
    private GameObject backRightDown;

    // МАССИВЫ ОБЪЕКТОВ ПО СТОРОНАМ

    protected GameObject[ , ] frontArray;
    protected GameObject[ , ] rightArray;
    protected GameObject[ , ] leftArray;
    protected GameObject[ , ] upArray;
    protected GameObject[ , ] downArray;
    protected GameObject[ , ] backArray;

    // ЛОГИЧЕСКИЕ ПОКАЗАТЕЛИ ПОВОРОТОВ ГРАНЕЙ

    private bool frontRotate;
    private bool rightRotate;
    private bool leftRotate;
    private bool upRotate;
    private bool downRotate;
    private bool backRotate;

    void Awake()
    {
        // НАХОЖДЕНИЕ ВСЕХ ЭЛЕМЕНТОВ


        // ФРОНТАЛЬНАЯ ГРАНЬ

        frontLeftUp = GameObject.Find("FrontLeftUp");
        frontMiddleUp = GameObject.Find("FrontMiddleUp");
        frontRightUp = GameObject.Find("FrontRightUp");

        frontLeftMiddle = GameObject.Find("FrontLeftMiddle");
        frontCenter = GameObject.Find("FrontCenter");
        frontRightMiddle = GameObject.Find("FrontRightMiddle");

        frontLeftDown = GameObject.Find("FrontLeftDown");
        frontMiddleDown = GameObject.Find("FrontMiddleDown");
        frontRightDown = GameObject.Find("FrontRightDown");
    
        // ПРАВАЯ ГРАНЬ

        rightLeftUp = GameObject.Find("FrontRightUp");
        rightMiddleUp = GameObject.Find("MiddleRightUp");
        rightRightUp = GameObject.Find("BackRightUp");

        rightLeftMiddle = GameObject.Find("FrontRightMiddle");
        rightCenter = GameObject.Find("MiddleRightMiddle");
        rightRightMiddle = GameObject.Find("BackRightMiddle");

        rightLeftDown = GameObject.Find("FrontRightDown");
        rightMiddleDown = GameObject.Find("MiddleRightDown");
        rightRightDown = GameObject.Find("BackRightDown");

        // ЛЕВАЯ ГРАНЬ

        leftLeftUp = GameObject.Find("BackLeftUp");
        leftMiddleUp = GameObject.Find("MiddleLeftUp");
        leftRightUp = GameObject.Find("FrontLeftUp");

        leftLeftMiddle = GameObject.Find("BackLeftMiddle");
        leftCenter = GameObject.Find("MiddleLeftMiddle");
        leftRightMiddle = GameObject.Find("FrontLeftMiddle");

        leftLeftDown = GameObject.Find("BackLeftDown");
        leftMiddleDown = GameObject.Find("MiddleLeftDown");
        leftRightDown = GameObject.Find("FrontLeftDown");

        // ВЕРХНЯЯ ГРАНЬ

        upLeftUp = GameObject.Find("BackLeftUp");
        upMiddleUp = GameObject.Find("BackMiddleUp");
        upRightUp = GameObject.Find("BackRightUp");

        upLeftMiddle = GameObject.Find("MiddleLeftUp");
        upCenter = GameObject.Find("MiddleMiddleUp");
        upRightMiddle = GameObject.Find("MiddleRightUp");

        upLeftDown = GameObject.Find("FrontLeftUp");
        upMiddleDown = GameObject.Find("FrontMiddleUp");
        upRightDown = GameObject.Find("FrontRightUp");

        // НИЖНЯЯ ГРАНЬ

        downLeftUp = GameObject.Find("FrontLeftDown");
        downMiddleUp = GameObject.Find("FrontMiddleDown");
        downRightUp = GameObject.Find("FrontRightDown");

        downLeftMiddle = GameObject.Find("MiddleLeftDown");
        downCenter = GameObject.Find("MiddleMiddleDown");
        downRightMiddle = GameObject.Find("MiddleRightDown");

        downLeftDown = GameObject.Find("BackLeftDown");
        downMiddleDown = GameObject.Find("BackMiddleDown");
        downRightDown = GameObject.Find("BackRightDown");

        // ЗАДНЯЯ ГРАНЬ

        backLeftUp = GameObject.Find("BackRightUp");
        backMiddleUp = GameObject.Find("BackMiddleUp");
        backRightUp = GameObject.Find("BackLeftUp");

        backLeftMiddle = GameObject.Find("BackRightMiddle");
        backCenter = GameObject.Find("BackCenter");
        backRightMiddle = GameObject.Find("BackLeftMiddle");

        backLeftDown = GameObject.Find("BackRightDown");
        backMiddleDown = GameObject.Find("BackMiddleDown");
        backRightDown = GameObject.Find("BackLeftDown");



        // ЗАПОЛНЕНИЕ МАССИВОВ В СТРОГОМ ПОРЯДКЕ

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

    public void RotateArray(GameObject[ , ] array, string result)
    {
        var temp = array[0, 0];

        array[0, 0] = array[2, 0];
        array[2, 0] = array[2, 2];
        array[2, 2] = array[0, 2];
        array[0, 2] = temp;

        temp = array[1, 0];
        array[1, 0] = array[2, 1];
        array[2, 1] = array[1, 2];
        array[1, 2] = array[0, 1];
        array[0, 1] = temp;

        Debug.Log(result);

        switch (result)
        {
            case "frontArray":
            {
                frontRotate = true;

                ResetUpArray();
                ResetRightArray();
                ResetLeftArray();
                ResetDownArray();

                frontRotate = false;
                break;
            }
            case "rightArray":
            {
                rightRotate = true;

                ResetUpArray();
                ResetFrontArray();
                ResetBackArray();
                ResetDownArray();

                rightRotate = false;
                break;
            }
            case "leftArray":
            {
                leftRotate = true; 

                ResetUpArray();
                ResetBackArray();
                ResetFrontArray();
                ResetDownArray();

                leftRotate = false;
                break;
            }
            case "upArray":
            {
                upRotate = true; 

                ResetBackArray();
                ResetRightArray();
                ResetLeftArray();
                ResetFrontArray();

                upRotate = false;
                break;
            }
            case "downArray":
            {
                downRotate = true;

                ResetFrontArray();
                ResetLeftArray();
                ResetRightArray();
                ResetBackArray();

                downRotate = false;
                break;
            }
            case "backArray":
            {
                backRotate = true; 

                ResetUpArray();
                ResetRightArray();
                ResetLeftArray();
                ResetDownArray();

                backRotate = false;
                break;
            }
        }
    }

    private void ResetFrontArray()
    {
        if (upRotate == true)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                frontArray[j, i] = upArray[k, i];
            }
        }
        else if (rightRotate == true)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                frontArray[i, k] = rightArray[i, j];
            }
        }
        else if (leftRotate == true)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                frontArray[i, j] = leftArray[i, k];
            }
        }
        else if (downRotate == true)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                frontArray[k, i] = downArray[j, i];
            }
        }
    }

    private void ResetRightArray()
    {
        Debug.Log("Перезапись правой стороны");

        if (frontRotate == true)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                rightArray[i, j] = frontArray[i, k];

                Debug.Log("Элемент левого столбца правой стороны заменен на   " + rightArray[i, j]);
            }
        }
        else if (backRotate == true)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                rightArray[i, k] = backArray[i, j];
            }
        }
        else if (upRotate == true)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                rightArray[j, i] = upArray[i, k];
            }
        }
        else if (downRotate == true)
        {
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                rightArray[k, i] = downArray[i, k];
            }
        }
    }

    private void ResetLeftArray()
    {
        Debug.Log("Перезапись левого массива");

        if (frontRotate == true)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                leftArray[i, k] = frontArray[i, j];

                Debug.Log("Элемент правого столбца левого массива заменен на   " + leftArray[i, k]);
            }
        }
        else if (backRotate == true)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                leftArray[i, j] = backArray[i, k];
            }
        }
        else if (upRotate == true)
        {
            int j = 0;

            for (int i = 0; i < 3; i++)
            {
                leftArray[j, i] = upArray[i, j];
            }
        }
        else if (downRotate == true)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                leftArray[k, i] = downArray[i, j];
            }
        }
    }

    private void ResetUpArray()
    {
        Debug.Log("Перезапись верхнего массива");

        if (frontRotate == true)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                upArray[k, i] = frontArray[j, i];

                Debug.Log("Элемент нижней строки верхнего массива заменен на   " + upArray[k, i]);
            }
        }
        else if (backRotate == true)
        {
            int j = 0;

            for (int i = 0; i < 3; i++)
            {
                upArray[j, i] = backArray[j, i];
            }
        }
        else if (rightRotate == true)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                upArray[i, k] = rightArray[j, i];
            }
        }
        else if (leftRotate == true)
        {
            int j = 0;

            for (int i = 0; i < 3; i++)
            {
                upArray[i, j] = leftArray[j, i];
            }
        }
    }

    private void ResetDownArray()
    {
        Debug.Log("Перезапись нижнего массива");

        if (frontRotate == true)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                downArray[j, i] = frontArray[k, i];
                
                Debug.Log("Элемент верхней строки нижнего массива заменен на   " + downArray[j, i]);
            }
        }
        else if (backRotate == true)
        {
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                downArray[k, i] = backArray[k, i];
            }
        }
        else if (rightRotate == true)
        {
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                downArray[i, k] = rightArray[k, i];
            }
        }
        else if (leftRotate == true)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                downArray[i, j] = leftArray[k, i];
            }
        }
    }

    private void ResetBackArray()
    {
        if (upRotate == true)
        {
            int j = 0;

            for (int i = 0; i < 3; i++)
            {
                backArray[j, i] = upArray[j, i];
            }
        }
        else if (leftRotate == true)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                backArray[i, k] = leftArray[i, j];
            }
        }
        else if (rightRotate == true)
        {
            int j = 0;
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                backArray[i, j] = rightArray[i, k];
            }
        }
        else if (downRotate == true)
        {
            int k = 2;

            for (int i = 0; i < 3; i++)
            {
                backArray[k, i] = downArray[i, k];
            }
        }
    }

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
                    Debug.Log($"Устанавливаем родителя правого массива для элемента {obj}");
                } 
                break;
            }
        }
    }
}