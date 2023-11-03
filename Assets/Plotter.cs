using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

public class Plotter : MonoBehaviour
{
    public string csvFile;
    public string xAxisVariable;
    public string yAxisVariable;
    public string zAxisVariable;

    public WineDatasetItem datasetPrefab;

    // Start is called before the first frame update
    void Start()
    {
        var itens = CsvReader<DatasetItem>.Process(csvFile, ItemMappers.DatasetItemFromTextLine);
        foreach (var item in itens)
        {
            Debug.Log(item.ToString());
            item.GetType().GetProperty(xAxisVariable).GetValue(item);
            float propertyInfoAxisX = Convert.ToSingle(item.GetType().GetProperty(xAxisVariable).GetValue(item));
            float propertyInfoAxisY = Convert.ToSingle(item.GetType().GetProperty(yAxisVariable).GetValue(item));
            float propertyInfoAxisZ =Convert.ToSingle(item.GetType().GetProperty(zAxisVariable).GetValue(item));

            var pos = new Vector3
            {
                x = propertyInfoAxisX,
                y = propertyInfoAxisY,
                z = propertyInfoAxisZ
            };

            Instantiate(datasetPrefab, pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
