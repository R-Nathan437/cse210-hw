class Costume
{
    //atributes
    public string _headWear;
    public string _gloves;
    public string _shoes;
    public string _upperGarment;
    public string _lowerGarment;
    public string _accesory;

    //behaviors

    public void ShowWardrobe()
    {
        string result = "";
        result += $"head: {_headWear}\n";
        result += $"gloves: {_gloves}\n";
        result += $"Feet: {_shoes}\n";
        result += $"Torso: {_upperGarment}\n";
        result += $"Legs: {_lowerGarment}\n";
        result += $"Accessory: {_accesory}\n";
        Console.WriteLine(result);
    }
}