using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitPaintings : MonoBehaviour
{
    public int paintingsVisited;
    
    // Start is called before the first frame update
    void Start()
    {
        paintingsVisited = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (paintingsVisited == 10)
        {
            Debug.Log("Finished");

        }
    }
}
