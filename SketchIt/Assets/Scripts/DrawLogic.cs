using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLogic : MonoBehaviour
{
    public Camera MainCamera;
    public GameObject brush;

    LineRenderer lineRenderer;

    Vector2 lastPos;

    private void Update()
    {
        Drawing();
    }

    void Drawing()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            NewBrush();
        }
        else if (Input.GetKey(KeyCode.Mouse0))
        {
            PointToCurrentPosition();
        }
        else
        {
            lineRenderer = null;
        }
    }

    void NewBrush()
    {
        GameObject brushNew = Instantiate(brush);
        lineRenderer = brushNew.GetComponent<LineRenderer>();

        Vector2 mPos = MainCamera.ScreenToWorldPoint(Input.mousePosition);

        lineRenderer.SetPosition(0, mPos);
        lineRenderer.SetPosition(1, mPos);

    }

    void AddPoint(Vector2 pointPos)
    {
        lineRenderer.positionCount++;
        int posIndex = lineRenderer.positionCount - 1;
        lineRenderer.SetPosition(posIndex, pointPos);
    }

    void PointToCurrentPosition()
    {
        Vector2 mPos = MainCamera.ScreenToWorldPoint(Input.mousePosition);
        if (lastPos != mPos)
        {
            AddPoint(mPos);
            lastPos = mPos;
        }
    }

}
