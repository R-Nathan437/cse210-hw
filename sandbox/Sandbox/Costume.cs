class Costume
{
    //atributes
    public string headWear;
    public string gloves;
    public string shoes;
    public string upperGarment;
    public string lowerGarment;
    public string accesory;

    //behaviors

    public void ShowWardrobe()
    {
        string result = "";
        result += $"head: {headWear}\n";
        result += $"gloves: {gloves}\n";
        result += $"Feet: {shoes}\n";
        result += $"Torso: {upperGarment}\n";
        result += $"Legs: {lowerGarment}\n";
        result += $"Accessory: {accesory}\n";
        Console.WriteLine(result);
    }
}