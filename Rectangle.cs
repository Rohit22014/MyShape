using System;
public class Rectangle
{
    
    public int Height { get; set; } // circle centre x-coordinate
    public int Width { get; set; } // circle centre y-coordinate
    public int RX { get; set; } // circle radius
    public int RY { get; set; }
    public string fill { get; set; }
    public string stroke { get; set; }
    public int StrokeWidth { get; set; }

    public Rectangle()
    {
        Height = 100;
        Width = 200;
        RX = 5;
        RY = 5;
        fill = "";
        stroke = "";
        StrokeWidth = 2; 
    }
public Rectangle(int height, int width, int rx, int ry, string fill, string stroke, int strokeWidth)
    {
        Height = height;
        Width = width;
        RX = rx;
        RY = ry;
        this.fill = fill;
        this.stroke = stroke;
        StrokeWidth = strokeWidth;
    }
    
public string addRectangle (int counter, int Height, int Width, int RX, int RY, string fill, string stroke, int StrokeWidth)
{
    string dispSVG =
        String.Format(
            @"<rect id = ""{0}"" width=""{1}"" height=""{2}"" rx=""{3}"" ry = ""{4}"" fill=""{5}"" stroke=""{6}"" stroke-width=""{7}""  />", counter, Height, Width,
            RX, RY, fill, stroke, StrokeWidth);
    counter++;
    return "".PadLeft(3, ' ') + dispSVG; 
}

public void deleteRectangle(int id)
{
        
}
    
public void updateRectangle(int id, int x, int y, int r)
{
        
}

    // public override string ToString()
    // {
    //     // convert the Object to a string
    //     string dispXYR = String.Format("Circle at ({0},{1}) R={2}.", X, Y, R);
    //
    //     // convert the object to an SVG element descriptor string for circle
    //     // note this contains the SVG canvas wrapper also - not ideal really
    //     string dispSVG =
    //         String.Format(
    //             @"<rect width=""{0}"" height=""{1}"" rx=""{2}"" ry=""{3}"" stroke=""black"" stroke-width=""2"" fill=""yellow"" />", X, Y,
    //             R);
    //     return "".PadLeft(3, ' ') + dispSVG;
    // }
}