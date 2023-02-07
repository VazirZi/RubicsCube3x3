using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassObject : MonoBehaviour
{

    //---- ФРОНТАЛЬНАЯ ГРАНЬ -----

    public GameObject frontLeftUp;
    public GameObject frontMiddleUp;
    public GameObject frontRightUp;

    public GameObject frontLeftMiddle;
    public GameObject frontCenter;
    public GameObject frontRightMiddle;

    public GameObject frontLeftDown;
    public GameObject frontMiddleDown;
    public GameObject frontRightDown;  

    //------ ПРАВАЯ ГРАНЬ ----------

    public GameObject rightLeftUp;
    public GameObject rightMiddleUp;
    public GameObject rightRightUp;

    public GameObject rightLeftMiddle;
    public GameObject rightCenter;
    public GameObject rightRightMiddle;

    public GameObject rightLeftDown;
    public GameObject rightMiddleDown;
    public GameObject rightRightDown;

    //------ ЛЕВАЯ ГРАНЬ -----------

    public GameObject leftLeftUp;
    public GameObject leftMiddleUp;
    public GameObject leftRightUp;

    public GameObject leftLeftMiddle;
    public GameObject leftCenter;
    public GameObject leftRightMiddle;

    public GameObject leftLeftDown;
    public GameObject leftMiddleDown;
    public GameObject leftRightDown;

    //------ ВЕРХНЯЯ ГРАНЬ ---------

    public GameObject upLeftUp;
    public GameObject upMiddleUp;
    public GameObject upRightUp;

    public GameObject upLeftMiddle;
    public GameObject upCenter;
    public GameObject upRightMiddle;

    public GameObject upLeftDown;
    public GameObject upMiddleDown;
    public GameObject upRightDown;

    //------ НИЖНЯЯ ГРАНЬ ----------

    public GameObject downLeftUp;
    public GameObject downMiddleUp;
    public GameObject downRightUp;

    public GameObject downLeftMiddle;
    public GameObject downCenter;
    public GameObject downRightMiddle;

    public GameObject downLeftDown;
    public GameObject downMiddleDown;
    public GameObject downRightDown;

    //------ ЗАДНЯЯ ГРАНЬ ---------

    public GameObject backLeftUp;
    public GameObject backMiddleUp;
    public GameObject backRightUp;

    public GameObject backLeftMiddle;
    public GameObject backCenter;
    public GameObject backRightMiddle;

    public GameObject backLeftDown;
    public GameObject backMiddleDown;
    public GameObject backRightDown;

    // МАССИВЫ ОБЪЕКТОВ ПО СТОРОНАМ

    public GameObject[ , ] frontArray;
    public GameObject[ , ] rightArray;
    public GameObject[ , ] leftArray;
    public GameObject[ , ] upArray;
    public GameObject[ , ] downArray;
    public GameObject[ , ] backArray;

    // ЛОГИЧЕСКИЕ ПОКАЗАТЕЛИ ПОВОРОТОВ ГРАНЕЙ

    public bool frontRotate;
    public bool rightRotate;
    public bool leftRotate;
    public bool upRotate;
    public bool downRotate;
    public bool backRotate;

    public void GetAllElement()
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

    public GameObject[ , ] RotateArray(ref GameObject[ , ] array, string result)
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
        return array;
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

    public void SetParent(string name, ref GameObject[ , ] array)
    {
        switch (name)
        {
            case "frontArray":
            {
                foreach (var obj in array)
                {
                    obj.transform.parent = frontCenter.transform;
                } 
                break;
            }
            case "rightArray":
            {
                foreach (var obj in array)
                {
                    obj.transform.parent = rightCenter.transform;
                    Debug.Log($"Устанавливаем родителя правого массива для элемента {obj}");
                } 
                break;
            }
        }
    }
}