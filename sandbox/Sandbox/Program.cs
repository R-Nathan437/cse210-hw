using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Costume nurse = new();
        nurse._headWear = "face mask";
        nurse._gloves = "nitrille";
        nurse._shoes = "sneakers";
        nurse._upperGarment = "scrubs";
        nurse._lowerGarment = "scrubs";
        nurse._accesory = "stethoscope";

                Costume detective = new();
        detective._headWear = "fedora";
        detective._gloves = "leather";
        detective._shoes = "loafers";
        detective._upperGarment = "trenchcoat";
        detective._lowerGarment = "slacks";
        detective._accesory = "magnifying glass";

        nurse.ShowWardrobe();
        detective.ShowWardrobe();
        
    }

}