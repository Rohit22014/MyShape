// break;
using System;
public class Ellipse
{
    public int CX { get; set; } // circle radius
    public int CY { get; set; }
    public int RX { get; set; } // circle radius
    public int RY { get; set; }
    public string fill { get; set; }
    public string stroke { get; set; }
    public int StrokeWidth { get; set; }

    public Ellipse()
    {
        CX = 100;
        CY = 200;
        RX = 5;
        RY = 5;
        fill = "";
        stroke = "";
        StrokeWidth = 2; 
    }
public Ellipse(int cx, int cy, int rx, int ry, string fill, string stroke, int strokeWidth)
    {
        CX = cx;
        CY = cy;
        RX = rx;
        RY = ry;
        this.fill = fill;
        this.stroke = stroke;
        StrokeWidth = strokeWidth;
    }
    
public string addEllipse (int counter, int CX, int CY, int RX, int RY, string fill, string stroke, int StrokeWidth)
{
    string dispSVG =
        String.Format(
            @"<ellipse id = ""{0}"" cx=""{1}"" cy=""{2}"" rx=""{3}"" ry=""{4}"" fill=""{5}"" stroke=""{6}"" stroke-width=""{7}""/>", counter, CX, CY,
            RX, RY, fill, stroke, StrokeWidth);
    counter++;
    return "".PadLeft(3, ' ') + dispSVG; 
}

public void deleteEllipse(int id)
{
        
}
    
public void updateEllipse(int id, int x, int y, int r)
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