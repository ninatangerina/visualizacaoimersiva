using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ItemMappers
{

    public static DatasetItem DatasetItemFromTextLine(string[] textLine)
    {
        return new DatasetItem
        {
            Class = float.Parse(textLine[0].PadLeft(1,'0')),
            Alcohol = float.Parse(textLine[1].PadLeft(1, '0')),
            MalicAcid = float.Parse(textLine[2].PadLeft(1, '0')),
            Ash = float.Parse(textLine[3].PadLeft(1, '0')),
            AshAlcalinity = float.Parse(textLine[4].PadLeft(1, '0')),
            Magnesium = float.Parse(textLine[5].PadLeft(1, '0')),
            TotalPhenols = float.Parse(textLine[6].PadLeft(1, '0')),
            Flavanoids = float.Parse(textLine[7].PadLeft(1, '0')),
            NonflavanoidPhenols = float.Parse(textLine[8].PadLeft(1, '0')),
            Proanthocyanins = float.Parse(textLine[9].PadLeft(1, '0')),
            ColorIntensity = float.Parse(textLine[10].PadLeft(1, '0')),
            Hue = float.Parse(textLine[11].PadLeft(1, '0')),
            OpcticalDensity = float.Parse(textLine[12].PadLeft(    1, '0')),
            Proline = float.Parse(textLine[13].PadLeft(1, '0'))
        };
    }
}
