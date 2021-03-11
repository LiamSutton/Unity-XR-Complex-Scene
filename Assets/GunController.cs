using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform barrelPoint;
    private LineRenderer lineRenderer;
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.SetPosition(0, barrelPoint.position);
        lineRenderer.SetPosition(1, barrelPoint.transform.forward * 100.0f);
    }
}
