using System;
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
        var itens = CsvReader<DatasetItem>.Process(csvFile, DatasetItem.MapFromLine);
        foreach (var item in itens)
        {
            var pos = new Vector3
            {
                x = Convert.ToSingle(item.GetType().GetProperty(xAxisVariable).GetValue(item)),
                y = Convert.ToSingle(item.GetType().GetProperty(yAxisVariable).GetValue(item)),
                z = Convert.ToSingle(item.GetType().GetProperty(zAxisVariable).GetValue(item))
            };

            var prefabInstance = Instantiate(datasetPrefab, pos, Quaternion.identity);
            prefabInstance.GetComponent<ObjectNote>().NoteText = item.Class.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
