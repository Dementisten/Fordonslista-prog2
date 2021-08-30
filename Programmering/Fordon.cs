class Fordon
{
    private string make;
    private string model;
    private int year;

    public string Make
    {
        get
        {
            return make;
        }
        set
        {
            make = value;
        }
    }

    public string Model
    {
        get
        {
            return model;
        }
        set
        {
            model = value;
        }
    }

    public int Year
    {
        get
        {
            return year;
        }
        set
        {
            if (value > 2022)
            {
                year = 2022;
            }
            else if (value < 1885)
            {
                year = 0000;
            }
            else
            {
                year = value;
            }
        }
    }

    public override string ToString()
    {
        return
        "\n Märke: " + make +
        "\n Modell: " + model +
        "\n Årsmodell: " + year;
    }

    public Fordon(string newMake, string newModel, int newYear)
    {
        Make = newMake;
        Model = newModel;
        Year = newYear;
    }

    public Fordon()
    {
    }
}