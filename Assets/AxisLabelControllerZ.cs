using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisLabelControllerZ : MonoBehaviour
{
    public Plotter plotter;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMesh>().text = plotter.zAxisVariable;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
