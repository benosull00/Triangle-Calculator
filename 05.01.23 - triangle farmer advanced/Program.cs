using System;

//This is looping the whole program, so if you want to find the area of one triangle and the base of another you don't have to restart the whole program
//My variable names are absolutely shockingly bad
int z = 1;
while (z < 3)
{

    Console.WriteLine("Are you trying to find the area or base/height?");
    string areaInput = Console.ReadLine();



    if (areaInput == "area")
    {
        //This is the section for finding the area
        //Below is converting the base and height into real numbers for use in the formula
        Console.WriteLine("Enter the base of the triangle");
        string baseLengthText = Console.ReadLine();
        double baseLength = Convert.ToDouble(baseLengthText);

        Console.WriteLine("Enter the height of the triangle");
        string heightText = Console.ReadLine();
        double height = Convert.ToDouble(heightText);

        //Below it is solving the formula for the area of a triangle
        double areaNumber = baseLength * height / 2;
        string area = Convert.ToString(areaNumber);
        Console.WriteLine("Total area: " + area + "\n");
    }

    else if (areaInput == "base")
    {
        //This is the section for finding the base
        Console.WriteLine("Enter the area of the triangle");
        string areaText = Console.ReadLine();
        double areaConv = Convert.ToDouble(areaText);

        Console.WriteLine("Enter the height of the triangle");
        string baseHeightText = Console.ReadLine();
        double baseHeightNumber = Convert.ToDouble(baseHeightText);

        //This is the same formula as for finding the area, just backwards
        double oneSide = areaConv * 2 / baseHeightNumber;
        string finalY = Convert.ToString(oneSide);
        Console.WriteLine("Length of base: " + finalY + "\n");
    }
    else if (areaInput == "height")
    {
        //This is the section for finding the height
        Console.WriteLine("Enter the area of the triangle");
        string areaText2 = Console.ReadLine();
        double areaConv2 = Convert.ToDouble(areaText2);

        Console.WriteLine("Enter the base of the triangle");
        string baseHeightText2 = Console.ReadLine();
        double baseHeightNumber2 = Convert.ToDouble(baseHeightText2);

        //Same formula as above
        double oneSide2 = areaConv2 * 2 / baseHeightNumber2;
        string finalY2 = Convert.ToString(oneSide2);
        Console.WriteLine("Length of height: " + finalY2 + "\n");
    }
}