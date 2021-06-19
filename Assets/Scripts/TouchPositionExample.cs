// This script outputs the position of an active touch contact

// Attach this script to a GameObject
// Create a Text GameObject (GameObject>UI>Text)
// Attach the Text to the Text field in the Inspector window of your GameObject

using UnityEngine;
using UnityEngine.UI;

public class TouchPositionExample : MonoBehaviour
{
    float originalTouchX = 0;
    public int leftRightState = 0;
    public int upDownState = 0;
    void Update()
    {
        
        if (Input.touchCount > 0)
        {
            Touch touch1 = Input.GetTouch(0);

            if(touch1.position.x < Screen.width / 2)
            {
                if (Input.touchCount > 1)
                {
                    Touch touch2 = Input.GetTouch(1);

                    TouchPhase test = touch2.phase;

                    if (test == TouchPhase.Began)
                    {
                        originalTouchX = touch2.position.x;
                        //originalTouchY = touch2.position.y;
                    }

                    
                    // Update the Text on the screen depending on current position of the touch each frame
                    if (touch2.position.x > Screen.width / 2)
                    {
                        if (test == TouchPhase.Stationary)
                        {
                            originalTouchX = touch2.position.x;
                            //originalTouchY = touch2.position.y;
                            leftRightState = 0;
                            //upDownState = 0;
                        }

                        if (touch2.position.x < originalTouchX)
                        {
                            
                            leftRightState = -1;
                        }

                        else if (touch2.position.x > originalTouchX)
                        {
                            
                            leftRightState = 1;
                        }

                        //if (touch2.position.y < originalTouchY)
                       // {

                         //   upDownState = -1;
                       // }

                       // else if (touch2.position.y > originalTouchY)
                       // {

                       //     upDownState = 1;
                       // }


                        if (test == TouchPhase.Ended)
                        {
                            leftRightState = 0;
                         //   upDownState = 0;
                        }
                    }
                }
            }

            else
            {
                Touch touch2 = Input.GetTouch(0);

                TouchPhase test = touch2.phase;

                if (test == TouchPhase.Began)
                {
                    originalTouchX = touch2.position.x;
                  //  originalTouchY = touch2.position.y;
                }
                // Update the Text on the screen depending on current position of the touch each frame
                if (touch2.position.x > Screen.width / 2)
                {
                    if (test == TouchPhase.Stationary)
                    {
                        originalTouchX = touch2.position.x;
                       // originalTouchY = touch2.position.y;
                        leftRightState = 0;
                      //  upDownState = 0;
                    }

                    if (touch2.position.x < originalTouchX)
                    {
                        leftRightState = -1;
                    }

                    else if (touch2.position.x > originalTouchX)
                    {
                        leftRightState = 1;
                    }

                   // if (touch2.position.y < originalTouchY)
                    //{
                        upDownState = -1;
                   // }

                   // else if (touch2.position.y > originalTouchY)
                   // {
                   //     upDownState = 1;
                   // }
                }

                if (test == TouchPhase.Ended)
                {
                    leftRightState = 0;
                   // upDownState = 0;
                }
            }
            
        }
        else
        {
            leftRightState = 0;
           // upDownState = 0;
        }
    }
}