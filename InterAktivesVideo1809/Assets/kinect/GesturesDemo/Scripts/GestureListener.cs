using UnityEngine;
using System.Collections;
using System;

public class GestureListener : MonoBehaviour, KinectGestures.GestureListenerInterface
{
	// GUI Text to display the gesture messages.
	public GUIText GestureInfo;
	
	public static bool swipeLeft;
	public static bool swipeRight;

    public static bool leftSwipe;
    public static bool rightSwipe;

    private void Start()
    {
        
    }

    /*
    public bool IsSwipeLeft()
	{
        if (swipeLeft)
		{
            swipeLeft = false;
			//return true;
		}
		//return false;
	}
	
	public bool IsSwipeRight()
	{
        if (swipeRight)
		{
			swipeRight = false;
			return true;
		}
		
		return false;
	}
    */
	
	public void UserDetected(uint userId, int userIndex)
	{
		// detect these user specific gestures
		KinectManager manager = KinectManager.Instance;
		
		manager.DetectGesture(userId, KinectGestures.Gestures.SwipeLeft);
		manager.DetectGesture(userId, KinectGestures.Gestures.SwipeRight);
        manager.DetectGesture(userId, KinectGestures.Gestures.SwipeUp);

		if(GestureInfo != null)
		{
			GestureInfo.GetComponent<GUIText>().text = "Swipe left or right to change the slides.";
		}
	}
	
	public void UserLost(uint userId, int userIndex)
	{
		if(GestureInfo != null)
		{
			GestureInfo.GetComponent<GUIText>().text = string.Empty;
		}
	}

	public void GestureInProgress(uint userId, int userIndex, KinectGestures.Gestures gesture, 
	                              float progress, KinectWrapper.NuiSkeletonPositionIndex joint, Vector3 screenPos)
	{
		// don't do anything here


	}

	public bool GestureCompleted (uint userId, int userIndex, KinectGestures.Gestures gesture, 
	                              KinectWrapper.NuiSkeletonPositionIndex joint, Vector3 screenPos)
	{
		string sGestureText = gesture + " detected";
		if(GestureInfo != null)
		{
			GestureInfo.GetComponent<GUIText>().text = sGestureText;
		}

        if (gesture == KinectGestures.Gestures.SwipeUp)
        {
            Debug.Log("Zoom In");
        }

        //LEFT SWIPE
        if (gesture == KinectGestures.Gestures.SwipeLeft)
        {
            leftSwipe = true;
        }
        if (leftSwipe)
        {
            gesture = KinectGestures.Gestures.None;
            
        }

        //RIGHT SWIPE
        if (gesture == KinectGestures.Gestures.SwipeRight)
        {
            rightSwipe = true;
        } 
        if (rightSwipe)
        {
            gesture = KinectGestures.Gestures.None;
        }
		return true;
	}

	public bool GestureCancelled (uint userId, int userIndex, KinectGestures.Gestures gesture, 
	                              KinectWrapper.NuiSkeletonPositionIndex joint)
	{
		// don't do anything here, just reset the gesture state
		return true;
	}
	
}
