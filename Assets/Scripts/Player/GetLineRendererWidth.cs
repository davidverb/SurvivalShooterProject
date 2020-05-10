using UnityEngine;
using System.Collections;

public class GetLineRendererWidth : MonoBehaviour
{
    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = gameObject.GetComponent<LineRenderer>();
        float startWidth = lineRenderer.startWidth;
        float endWidth = lineRenderer.endWidth;
        Debug.Log("Start width: " + startWidth + '\t' + "End width: " + endWidth);
    }
}