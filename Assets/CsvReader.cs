using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

// Based on: https://bravenewmethod.com/2014/09/13/lightweight-csv-reader-for-unity/

public class CsvReader<T>
{
    public static IEnumerable<T> Process(string filePath, Func<string[], T> mapper)
    {
        var csvData = Resources.Load<TextAsset>(filePath);

        if (csvData == null)
        {
            Debug.LogError("CSV file not found: " + filePath);
        }

        var itemLines = csvData.text
            .Split('\n')
            .ToList().AsReadOnly().Skip(1)
            .Select(itemLine => itemLine.Split(','));

        return itemLines.Select(itemLine => mapper(itemLine));
    }
}


