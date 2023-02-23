using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Данный класс производит вычисления для осуществления поворота грани.
/// </summary>

public static class Calculation
{
    #region SWIPES_NAME_(STRING_CONSTANTS)
    private const string upLeftSwipe = "upLeftSwipe";
    private const string upRightSwipe = "upRightSwipe";
    private const string horizontalLeftSwipe = "horizontalLeftSwipe";
    private const string horizontalRightSwipe = "horizontalRightSwipe";
    private const string downLeftSwipe = "downLeftSwipe";
    private const string downRightSwipe = "downRightSwipe";
    private const string frontRightDownSwipe = "frontRightDownSwipe";
    private const string frontLeftUpSwipe = "frontLeftUpSwipe";
    private const string frontVerticalUpSwipe = "frontVerticalUpSwipe";
    private const string frontVerticalDownSwipe = "frontVerticalDownSwipe";
    private const string backRightDownSwipe = "backRightDownSwipe";
    private const string backLeftUpSwipe = "backLeftUpSwipe";
    private const string rightRightUpSwipe = "rightRightUpSwipe";
    private const string rightLeftDownSwipe = "rightLeftDownSwipe";
    private const string rightVerticalUpSwipe = "rightVerticalUpSwipe";
    private const string rightVerticalDownSwipe = "rightVerticalDownSwipe";
    private const string leftRightUpSwipe = "leftRightUpSwipe";
    private const string leftLeftDownSwipe = "leftLeftDownSwipe";

    #endregion

    #region ELEMENTS_NAME_(STRING_CONSTANTS)
    
    private const string frontUpLeftElement = "frontUpLeftElement";
    private const string frontUpMiddleElement = "frontUpMiddleElement";
    private const string frontUpRightElement = "frontUpRightElement";
    private const string frontMiddleLeftElement = "frontMiddleLeftElement";
    private const string frotnCenterElement = "frontCenterElement";
    private const string frontMiddleRightElement = "frontMiddleRightElement";
    private const string frontDownLeftElement = "frontDownLeftElement";
    private const string frontDownMiddleElement = "frontDownMiddleElement";
    private const string frontDownRightElement = "frontDownRightElement";
    private const string rightUpMiddleElement = "rightUpMiddleElement";
    private const string rightUpRightElement = "rightUpRightElement";
    private const string rightCenterElement = "rightCenterElement";
    private const string rightMiddleRightElement = "rightMiddleRightElement";
    private const string rightDownMiddleElement = "rightDownMiddleElement";
    private const string rightDownRightElement = "rightDownRightElement";
    private const string leftUpMiddleElement = "leftUpMiddleElement";
    private const string upCenterElement = "upCenterElement";
    private const string backUpMiddleElement = "backUpMiddleElement";
    private const string backUpLeftElement = "backUpLeftElement";

    #endregion

    #region EDGES_NAME_(STRING_CONSTANTS) 
    private const string upEdge = "upEdge";
    private const string downEdge = "downEdge";
    private const string frontEdge = "frontEdge";
    private const string backEdge = "backEdge";
    private const string rightEdge = "rightEdge";
    private const string leftEdge = "leftEdge";
    private const string frontVerticalEdge = "frontVerticalEdge";
    private const string rightVerticalEdge = "rightVerticalEdge";
    private const string horizontalEdge = "horizontalEdge";

    #endregion

    public static bool wasLeftMouseClick;
    public static bool wasRightMouseClick;
    public static int countOfLeftMouseButtonClick;
    public static int countOfRightMouseButtonClick;
    public static string FindNameOfObjectByHisPosition(GameObject element)
    {
        string elementName = string.Empty;

        float x = element.transform.position.x;
        float y = element.transform.position.y;
        float z = element.transform.position.z;

        if (IsFrontUpLeftElement(x, y, z)) elementName = frontUpLeftElement;
        else if(IsFrontUpMiddleElement(x, y, z)) elementName = frontUpMiddleElement;
        else if(IsFrontUpRightElement(x, y, z)) elementName = frontUpRightElement;
        else if(IsFrontMiddleLeftElement(x, y, z)) elementName = frontMiddleLeftElement;
        else if(IsFrontCenterElement(x, y, z)) elementName = frotnCenterElement;
        else if(IsFrontMiddleRightElement(x, y, z)) elementName = frontMiddleRightElement;
        else if(IsFrontDownLeftElement(x, y, z)) elementName = frontDownLeftElement;
        else if(IsFrontDownMiddleElement(x, y, z)) elementName = frontDownMiddleElement;
        else if(IsFrontDownRightElement(x, y, z)) elementName = frontDownRightElement;

        else if(IsRightUpMiddleElement(x, y, z)) elementName = rightUpMiddleElement;
        else if(IsRightUpRightElement(x, y, z)) elementName = rightUpRightElement;
        else if(IsRightCenterElement(x, y, z)) elementName = rightCenterElement;
        else if(IsRightMiddleRightElement(x, y, z)) elementName = rightMiddleRightElement;
        else if(IsRightDownMiddleElement(x, y, z)) elementName = rightDownMiddleElement;
        else if(IsRightDownRightElement(x, y, z)) elementName = rightDownRightElement;

        else if(IsLeftUpMiddleElement(x, y, z)) elementName = leftUpMiddleElement;
        else if(IsUpCenterElement(x, y, z)) elementName = upCenterElement;
        else if(IsBackUpMiddleElement(x, y, z)) elementName = backUpMiddleElement;
        else if(IsBackUpLeftElement(x, y, z)) elementName = backUpLeftElement;

        return elementName;
    }

    #region METHODS_FOR_FINDING_THE_ELEMENT_POSITION

    private static bool IsFrontUpLeftElement(float x, float y, float z)
    {
        return x == -1f && y == 1f && z == -1f;
    }

    private static bool IsFrontUpMiddleElement(float x, float y, float z)
    {
        return x == 0 && y == 1f && z == -1f;
    }

    private static bool IsFrontUpRightElement(float x, float y, float z)
    {
        return x == 1f && y == 1f && z == -1f;
    }

    private static bool IsFrontMiddleLeftElement(float x, float y, float z)
    {
        return x == -1f && y == 0 && z == -1f;
    }

    private static bool IsFrontCenterElement(float x, float y, float z)
    {
        return x == 0 && y == 0 && z == -1f;
    }

    private static bool IsFrontMiddleRightElement(float x, float y, float z)
    {
        return x == 1f && y == 0 && z == -1f;
    }

    private static bool IsFrontDownLeftElement(float x, float y, float z)
    {
        return x == -1f && y == -1f && z == -1f;
    }

    private static bool IsFrontDownMiddleElement(float x, float y, float z)
    {
        return x == 0 && y == -1f && z == -1f;
    }

    private static bool IsFrontDownRightElement(float x, float y, float z)
    {
        return x == 1f && y == -1f && z == -1f;
    }

    private static bool IsRightUpMiddleElement(float x, float y, float z)
    {
        return x == 1f && y == 1f && z == 0;
    }

    private static bool IsRightUpRightElement(float x, float y, float z)
    {
        return x == 1f && y == 1f && z == 1f;
    }

    private static bool IsRightCenterElement(float x, float y, float z)
    {
        return x == 1f && y == 0 && z == 0;
    }

    private static bool IsRightMiddleRightElement(float x, float y, float z)
    {
        return x == 1f && y == 0 && z == 1f;
    }

    private static bool IsRightDownMiddleElement(float x, float y, float z)
    {
        return x == 1f && y == -1f && z == 0;
    }

    private static bool IsRightDownRightElement(float x, float y, float z)
    {
        return x == 1f && y == -1f && z == 1f;
    }

    private static bool IsLeftUpMiddleElement(float x, float y, float z)
    {
        return x == -1f && y == 1f && z == 0;
    }

    private static bool IsUpCenterElement(float x, float y, float z)
    {
        return x == 0 && y == 1f && z == 0;
    }

    private static bool IsBackUpMiddleElement(float x, float y, float z)
    {
        return x == 0 && y == 1f && z == 1f;
    }

    private static bool IsBackUpLeftElement(float x, float y, float z)
    {
        return x == -1f && y == 1f && z == 1f;
    }

    #endregion
    public static string FindDirectionOfSwipe (Vector2 swipe, string element)
    {
        string direction = string.Empty;

        if (UpEdgeLeftSwipe(swipe, element)) direction = upLeftSwipe;
        else if (UpEdgeRightSwipe(swipe, element)) direction = upRightSwipe;
        else if (HorizontalLeftSwipe(swipe, element)) direction = horizontalLeftSwipe;
        else if (HorizontalRightSwipe(swipe, element)) direction = horizontalRightSwipe;
        else if (DownEdgeLeftSwipe(swipe, element)) direction = downLeftSwipe;
        else if (DownEdgeRightSwipe(swipe, element)) direction = downRightSwipe;

        else if (FrontEdgeDownRightSwipe(swipe, element)) direction = frontRightDownSwipe;
        else if (FrontEdgeUpLeftSwipe(swipe, element)) direction = frontLeftUpSwipe;
        else if (FrontVerticalUpSwipe(swipe, element)) direction = frontVerticalUpSwipe;
        else if (FrontVerticalDownSwipe(swipe, element)) direction = frontVerticalDownSwipe;
        else if (BackEdgeDownRightSwipe(swipe, element)) direction = backRightDownSwipe;
        else if (BackEdgeUpLeftSwipe(swipe, element)) direction = backLeftUpSwipe;

        else if (RightEdgeDownLeftSwipe(swipe, element)) direction = rightLeftDownSwipe;
        else if (RightEdgeUpRightSwipe(swipe, element)) direction = rightRightUpSwipe;
        else if (RightVerticalUpSwipe(swipe, element)) direction = rightVerticalUpSwipe; 
        else if (RightVerticalDownSwipe(swipe, element)) direction = rightVerticalDownSwipe;
        else if (LeftEdgeDownLeftSwipe(swipe, element)) direction = leftLeftDownSwipe;
        else if (LeftEdgeUpRightSwipe(swipe, element)) direction = leftRightUpSwipe;

        return direction;
    }

    #region METHODS_FOR_FINDING_THE_SWIPE_DIRECTION

    private static bool UpEdgeLeftSwipe(Vector2 swipe, string elementName)
    {
        return swipe.x < 0 && swipe.y < 0.5f && swipe.y > -0.5f && 
              (elementName == frontUpMiddleElement ||
               elementName == frontUpRightElement || 
               elementName == rightUpMiddleElement);
    }

    private static bool UpEdgeRightSwipe(Vector2 swipe, string elementName)
    {
        return swipe.x > 0 && swipe.y < 0.5f && swipe.y > -0.5f && 
              (elementName == frontUpMiddleElement || 
               elementName == frontUpRightElement || 
               elementName == rightUpMiddleElement);
    }

    private static bool HorizontalLeftSwipe (Vector2 swipe, string elementName)
    {
        return swipe.x < 0 && swipe.y < 0.5f && swipe.y > -0.5f && 
              (elementName == frontMiddleLeftElement ||
               elementName == frotnCenterElement || 
               elementName == frontMiddleRightElement ||
               elementName == rightCenterElement ||
               elementName == rightMiddleRightElement);
    }

    private static bool HorizontalRightSwipe (Vector2 swipe, string elementName)
    {
        return swipe.x > 0 && swipe.y < 0.5f && swipe.y > -0.5f && 
              (elementName == frontMiddleLeftElement ||
               elementName == frotnCenterElement || 
               elementName == frontMiddleRightElement ||
               elementName == rightCenterElement ||
               elementName == rightMiddleRightElement);
    }

    private static bool DownEdgeLeftSwipe(Vector2 swipe, string elementName)
    {   
        return swipe.x < 0 && swipe.y < 0.5f && swipe.y > -0.5f && 
              (elementName == frontDownMiddleElement || 
               elementName == frontDownRightElement || 
               elementName == rightDownMiddleElement);
    }

    private static bool DownEdgeRightSwipe(Vector2 swipe, string elementName)
    {
        return swipe.x > 0 && swipe.y < 0.5f && swipe.y > -0.5f && 
              (elementName == frontDownMiddleElement || 
               elementName == frontDownRightElement || 
               elementName == rightDownMiddleElement);
    }

    private static bool FrontEdgeUpLeftSwipe(Vector2 swipe, string elementName)
    {
        return swipe.x < 0 && swipe.y > 0.5f && 
              (elementName == frontUpMiddleElement || 
               elementName == frontUpRightElement ||
               elementName == frontMiddleRightElement ||
               elementName == frontDownRightElement);
    }

    private static bool FrontEdgeDownRightSwipe(Vector2 swipe, string elementName)
    {
        return swipe.x > 0 && swipe.y < 0 && 
              (elementName == frontUpLeftElement || 
               elementName == frontUpMiddleElement ||
               elementName == frontUpRightElement ||
               elementName == frontMiddleRightElement);
    }

    private static bool FrontVerticalUpSwipe(Vector2 swipe, string elementName)
    {
        return swipe.x > 0 && swipe.y > 0.5 && 
              (elementName == frontDownMiddleElement || 
               elementName == frotnCenterElement ||
               elementName == frontUpMiddleElement ||
               elementName == upCenterElement ||
               elementName == backUpMiddleElement);
    }

    private static bool FrontVerticalDownSwipe(Vector2 swipe, string elementName)
    {
        return swipe.x < 0 && swipe.y < 0.5 && 
              (elementName == frontDownMiddleElement || 
               elementName == frotnCenterElement ||
               elementName == frontUpMiddleElement ||
               elementName == upCenterElement ||
               elementName == backUpMiddleElement);
    }

    private static bool BackEdgeUpLeftSwipe(Vector2 swipe, string elementName)
    {
        return swipe.x < 0 && swipe.y > 0.5f && 
              (elementName == backUpMiddleElement || 
               elementName == rightUpRightElement ||
               elementName == rightMiddleRightElement ||
               elementName == rightDownRightElement);
    }

    private static bool BackEdgeDownRightSwipe(Vector2 swipe, string elementName)
    {
        return swipe.x > 0 && swipe.y < 0 && 
              (elementName == backUpLeftElement ||
               elementName == backUpMiddleElement ||
               elementName == rightUpRightElement ||
               elementName == rightMiddleRightElement);
    }

    private static bool RightEdgeUpRightSwipe(Vector2 swipe, string elementName)
    {
        return swipe.x > 0 && swipe.y > 0.5f && 
              (elementName == frontDownRightElement || 
               elementName == frontMiddleRightElement ||
               elementName == frontUpRightElement ||
               elementName == rightUpMiddleElement);
    }

    private static bool RightEdgeDownLeftSwipe(Vector2 swipe, string elementName)
    {
        return swipe.x < 0 && swipe.y < 0 && 
              (elementName == rightUpRightElement || 
               elementName == rightUpMiddleElement ||
               elementName == frontUpRightElement ||
               elementName == frontMiddleRightElement);
    }

    private static bool RightVerticalUpSwipe(Vector2 swipe, string elementName)
    {
        return swipe.x < 0 && swipe.y > 0.5 && 
              (elementName == leftUpMiddleElement || 
               elementName == upCenterElement ||
               elementName == rightUpMiddleElement ||
               elementName == rightCenterElement ||
               elementName == rightDownMiddleElement);
    }

    private static bool RightVerticalDownSwipe(Vector2 swipe, string elementName)
    {
        return swipe.x > 0 && swipe.y < 0 && 
              (elementName == leftUpMiddleElement || 
               elementName == upCenterElement ||
               elementName == rightUpMiddleElement ||
               elementName == rightCenterElement ||
               elementName == rightDownMiddleElement);
    }

    private static bool LeftEdgeUpRightSwipe(Vector2 swipe, string elementName)
    {
        return swipe.x > 0 && swipe.y > 0.5f && 
              (elementName == frontDownLeftElement || 
               elementName == frontMiddleLeftElement ||
               elementName == frontUpLeftElement);
    }

    private static bool LeftEdgeDownLeftSwipe(Vector2 swipe, string elementName)
    {
        return swipe.x < 0 && swipe.y < 0 && 
              (elementName == backUpLeftElement ||
               elementName == leftUpMiddleElement ||
               elementName == frontUpLeftElement);
    }

    #endregion
    public static string FindActiveEdge(string elementName, string swipeDirection)
    {
        string nameOfActiveEdge = string.Empty;

        if (IsUpEdge(elementName, swipeDirection)) nameOfActiveEdge = upEdge;
        else if (IsHorizontalEdge(elementName, swipeDirection)) nameOfActiveEdge = horizontalEdge;
        else if (IsDownEdge(elementName, swipeDirection)) nameOfActiveEdge = downEdge;
        else if (IsFrontEdge(elementName, swipeDirection)) nameOfActiveEdge = frontEdge;
        else if (IsFrontVerticalEdge(elementName, swipeDirection)) nameOfActiveEdge = frontVerticalEdge;
        else if (IsBackEdge(elementName, swipeDirection)) nameOfActiveEdge = backEdge;
        else if (IsRightEdge(elementName, swipeDirection)) nameOfActiveEdge = rightEdge;
        else if (IsRightVerticalEdge(elementName, swipeDirection)) nameOfActiveEdge = rightVerticalEdge;
        else if (IsLeftEdge(elementName, swipeDirection)) nameOfActiveEdge = leftEdge;

        return nameOfActiveEdge;
    }

    #region METHODS_FOR_FINDING_THE_ACTIVE_EDGE

    private static bool IsUpEdge(string elementName, string swipeDirection)
    {
        return (elementName == frontUpLeftElement || 
                elementName == frontUpMiddleElement || 
                elementName == frontUpRightElement ||
                elementName == rightUpMiddleElement ||
                elementName == rightUpRightElement) && 
                    (swipeDirection == upLeftSwipe || 
                     swipeDirection == upRightSwipe);
    }

    private static bool IsHorizontalEdge(string elementName, string swipeDirection)
    {
        return (elementName == frontMiddleLeftElement || 
                elementName == frotnCenterElement || 
                elementName == frontMiddleRightElement ||
                elementName == rightCenterElement ||
                elementName == rightMiddleRightElement) && 
                    (swipeDirection == horizontalLeftSwipe || 
                     swipeDirection == horizontalRightSwipe);
    }

    private static bool IsDownEdge(string elementName, string swipeDirection)
    {
        return (elementName == frontDownLeftElement || 
                elementName == frontDownMiddleElement || 
                elementName == frontDownRightElement ||
                elementName == rightDownMiddleElement ||
                elementName == rightDownRightElement) && 
                    (swipeDirection == downLeftSwipe || 
                     swipeDirection == downRightSwipe);
    }

    private static bool IsFrontEdge(string elementName, string swipeDirection)
    {
        return (elementName == frontUpLeftElement || 
                elementName == frontUpMiddleElement || 
                elementName == frontUpRightElement ||
                elementName == frontMiddleRightElement ||
                elementName == frontDownRightElement) && 
                    (swipeDirection == frontLeftUpSwipe || 
                     swipeDirection == frontRightDownSwipe);
    }

    private static bool IsFrontVerticalEdge(string elementName, string swipeDirection)
    {
        return (elementName == frontDownMiddleElement || 
                elementName == frotnCenterElement || 
                elementName == frontUpMiddleElement ||
                elementName == upCenterElement ||
                elementName == backUpMiddleElement) && 
                    (swipeDirection == frontVerticalUpSwipe || 
                     swipeDirection == frontVerticalDownSwipe);
    }

    private static bool IsBackEdge(string elementName, string swipeDirection)
    {
        return (elementName == backUpLeftElement ||
                elementName == backUpMiddleElement ||
                elementName == rightUpRightElement ||
                elementName == rightMiddleRightElement || 
                elementName == rightDownRightElement) && 
                    (swipeDirection == backLeftUpSwipe || 
                     swipeDirection == backRightDownSwipe);
    }
   
    private static bool IsRightEdge(string elementName, string swipeDirection)
    {
        return (elementName == frontDownRightElement ||
                elementName == frontMiddleRightElement ||
                elementName == frontUpRightElement ||
                elementName == rightUpMiddleElement || 
                elementName == rightUpRightElement) && 
                    (swipeDirection == rightRightUpSwipe || 
                     swipeDirection == rightLeftDownSwipe);
    }

    private static bool IsRightVerticalEdge(string elementName, string swipeDirection)
    {
        return (elementName == leftUpMiddleElement ||
                elementName == upCenterElement ||
                elementName == rightUpMiddleElement ||
                elementName == rightCenterElement || 
                elementName == rightDownMiddleElement) && 
                    (swipeDirection == rightVerticalUpSwipe || 
                     swipeDirection == rightVerticalDownSwipe);
    }

    private static bool IsLeftEdge(string elementName, string swipeDirection)
    {
        return (elementName == frontDownLeftElement ||
                elementName == frontMiddleLeftElement ||
                elementName == frontUpLeftElement ||
                elementName == leftUpMiddleElement || 
                elementName == backUpLeftElement) && 
                    (swipeDirection == leftLeftDownSwipe || 
                     swipeDirection == leftRightUpSwipe);
    }

    public static Vector3 FindRaysDirecrion(string nameOfActiveEdge)
    {
        Vector3 raysDirection = new Vector3();

        switch (nameOfActiveEdge)
        {
            case upEdge: raysDirection = -Vector3.up; break;
            case downEdge: raysDirection = Vector3.up; break;
            case frontEdge: raysDirection = Vector3.forward; break;
            case backEdge: raysDirection = -Vector3.forward; break;
            case rightEdge: raysDirection = -Vector3.right; break;
            case leftEdge: raysDirection = Vector3.right; break;
        }

        return raysDirection;
    } 

    #endregion
    public static Quaternion SetRotationForEdge(string nameOfActiveEdge, string directionOfSwipe)
    {
        Quaternion resultQuaternion = new Quaternion();
        
        if ((nameOfActiveEdge == upEdge || nameOfActiveEdge == downEdge || nameOfActiveEdge == horizontalEdge) &&
            (directionOfSwipe == upLeftSwipe || directionOfSwipe == downLeftSwipe || directionOfSwipe == horizontalLeftSwipe)) 
                
                resultQuaternion = new Quaternion(0, 90f, 0, 0);
        
        else if ((nameOfActiveEdge == upEdge || nameOfActiveEdge == downEdge || nameOfActiveEdge == horizontalEdge) &&
                 (directionOfSwipe == upRightSwipe || directionOfSwipe == downRightSwipe || directionOfSwipe == horizontalRightSwipe)) 
                    
                    resultQuaternion = new Quaternion(0, -90f, 0, 0);
        
        else if ((nameOfActiveEdge == rightEdge || nameOfActiveEdge == leftEdge || nameOfActiveEdge == frontVerticalEdge) &&
                 (directionOfSwipe == rightLeftDownSwipe || directionOfSwipe == leftLeftDownSwipe || directionOfSwipe == frontVerticalDownSwipe)) 
                    
                    resultQuaternion = new Quaternion(-90f, 0, 0, 0);
        
        else if ((nameOfActiveEdge == rightEdge || nameOfActiveEdge == leftEdge || nameOfActiveEdge == frontVerticalEdge) &&
                 (directionOfSwipe == rightRightUpSwipe || directionOfSwipe == leftRightUpSwipe || directionOfSwipe == frontVerticalUpSwipe)) 
                    
                    resultQuaternion = new Quaternion(90f, 0, 0, 0);
        
        else if ((nameOfActiveEdge == frontEdge || nameOfActiveEdge == backEdge || nameOfActiveEdge == rightVerticalEdge) &&
                 (directionOfSwipe == frontRightDownSwipe || directionOfSwipe == backRightDownSwipe || directionOfSwipe == rightVerticalDownSwipe)) 
                    
                    resultQuaternion = new Quaternion(0, 0, -90f, 0);
        
        else if ((nameOfActiveEdge == frontEdge || nameOfActiveEdge == backEdge || nameOfActiveEdge == rightVerticalEdge) &&
                 (directionOfSwipe == frontLeftUpSwipe || directionOfSwipe == backLeftUpSwipe || directionOfSwipe == rightVerticalUpSwipe)) 
                    
                    resultQuaternion = new Quaternion(0, 0, 90f, 0);
        
        return resultQuaternion;
    }
}