using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Costume nurse = new();
        nurse.headWear = "face mask";
        nurse.gloves = "nitrille";
        nurse.shoes = "sneakers";
        nurse.upperGarment = "scrubs";
        nurse.lowerGarment = "scrubs";
        nurse.accesory = "stethoscope";

                Costume detective = new();
        detective.headWear = "fedora";
        detective.gloves = "leather";
        detective.shoes = "loafers";
        detective.upperGarment = "trenchcoat";
        detective.lowerGarment = "slacks";
        detective.accesory = "magnifying glass";

        nurse.ShowWardrobe();
        detective.ShowWardrobe();
        
    }

}