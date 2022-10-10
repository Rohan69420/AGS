using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BrushAlterer : MonoBehaviour
{
    // Start is called before the first frame update
    public LineRenderer lineRenderer;
    
    void Start()
        {
        Debug.Log("Brush Altering function launched successfully!");
        
    }
    public void ChangeToCyan()
    { 
        lineRenderer.startColor = Color.cyan;
        lineRenderer.endColor = Color.cyan;
    }
    public void ChangeToGreen()
    {
        lineRenderer.startColor = Color.green;
        lineRenderer.endColor = Color.green;
    }
    public void ChangeToRed()
    {
        lineRenderer.startColor = Color.red;
        lineRenderer.endColor = Color.red;
    }
    public void ChangeToYellow()
    {
        lineRenderer.startColor = Color.yellow;
        lineRenderer.endColor = Color.yellow;
    }
    public void InvokeFakeEraser()
    {
        lineRenderer.startColor = Color.white;
        lineRenderer.endColor = Color.white;
    }
    //needs dynamic float for sliders
    public void ChangeBrushWidth(System.Single width)
    {
        Debug.Log("recieved val:" + width);
        //brushInstance.GetComponent<lineRenderer>().SetWidth(2.0f, 1.5f);
        lineRenderer.startWidth=width;
        lineRenderer.endWidth=width;
    }
    

}


