using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WineDatasetItem : MonoBehaviour
{
    public string name;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = this.transform.localPosition;
        this.transform.localPosition = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
