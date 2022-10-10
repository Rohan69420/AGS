using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saver : MonoBehaviour
{

   public GameObject CanvasToHide;


    public void CaptureDrawnBoard()
    {

        string path = "Assets/SavedImages/Capture_" + System.DateTime.Now.ToString("HH-mm-ss--dd-MM-yyyy") + ".png";
        
        ScreenCapture.CaptureScreenshot(path);
        Debug.Log("Image saved!");

    }
   
    
    void Update()
    {
     
    }
}
