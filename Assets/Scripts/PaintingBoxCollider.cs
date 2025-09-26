using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PaintingBoxCollider : MonoBehaviour
{
    public Light spotlight;
    public VisitPaintings VisitPaintings;
    private bool hasTriggered;

    // Start is called before the first frame update
    void Start()
    {
        spotlight = GetComponent<Light>();
        hasTriggered = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        spotlight.range = 100;
        if (!hasTriggered)
        {
            VisitPaintings.paintingsVisited += 1;
            hasTriggered = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        spotlight.range = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
