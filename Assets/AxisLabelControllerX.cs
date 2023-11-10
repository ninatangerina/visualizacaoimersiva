using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisLabelControllerX : MonoBehaviour
{
    public Plotter plotter;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMesh>().text = plotter.xAxisVariable;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
