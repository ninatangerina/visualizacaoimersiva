using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

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

