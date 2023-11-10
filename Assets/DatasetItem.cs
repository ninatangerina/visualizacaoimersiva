
using System.Runtime.CompilerServices;
/**
* Represents an Item on Wine dataset
*/
public class DatasetItem
{
    public double Class {  get; set; }

    public double Alcohol { get; set; }

    public double MalicAcid{ get; set; }

    public double Ash { get; set; }

    public double AshAlcalinity { get; set; }

    public double Magnesium { get; set; }

    public double TotalPhenols { get; set; }

    public double Flavanoids { get; set; }

    public double NonflavanoidPhenols { get; set; }

    public double Proanthocyanins { get; set; }

    public double ColorIntensity { get; set; }

    public double Hue { get; set; }

    /// <summary>
    /// represents the OD280/OD315 ratio
    /// measurement used in wine analysis to assess the phenolic content and the color stability of red wines
    /// OD stands for optical density, and the numbers 280 and 315 represent specific wavelengths of light in the ultraviolet-visible (UV-Vis) spectrum
    /// </summary>
    public double OpcticalDensity { get; set; }

    public double Proline { get; set; }

    public static DatasetItem MapFromLine(string[] textLine)
    {
        return new DatasetItem
        {
            Class = float.Parse(textLine[0].PadLeft(1, '0')),
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
            OpcticalDensity = float.Parse(textLine[12].PadLeft(1, '0')),
            Proline = float.Parse(textLine[13].PadLeft(1, '0'))
        };
    }

    public override string ToString()
    {
        return $"Class: {Class}, " +
               $"Alcohol: {Alcohol}, " +
               $"Malic Acid: {MalicAcid}, " +
               $"Ash: {Ash}, " +
               $"Ash Alcalinity: {AshAlcalinity}, " +
               $"Magnesium: {Magnesium}, " +
               $"Total Phenols: {TotalPhenols}, " +
               $"Flavanoids: {Flavanoids}, " +
               $"Nonflavanoid Phenols: {NonflavanoidPhenols}, " +
               $"Proanthocyanins: {Proanthocyanins}, " +
               $"Color Intensity: {ColorIntensity}, " +
               $"Hue: {Hue}, " +
               $"Optical Density: {OpcticalDensity}, " +
               $"Proline: {Proline}";
    }
}

