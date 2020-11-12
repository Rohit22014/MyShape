// break;
using System;
public class Polyline
{
    public string fill { get; set; }
    public string stroke { get; set; }
    public int StrokeWidth { get; set; }

    public Polyline()
    {
        fill = "";
        stroke = "";
        StrokeWidth = 2; 
    }
    public Polyline(string fill, string stroke, int strokeWidth)
    {
        this.fill = fill;
        this.stroke = stroke;
        StrokeWidth = strokeWidth;
    }
    
    public string addPolyline (int counter, int point1x, int point1y, int point2x, int RY, string fill, string stroke, int StrokeWidth)
    {
        // string dispSVG =
        //     String.Format(
        //         @"<ellipse id = ""{0}"" cx=""{1}"" cy=""{2}"" rx=""{3}"" ry=""{4}"" fill=""{5}"" stroke=""{6}"" stroke-width=""{7}""  />", counter, CX, CY,
        //         RX, RY, fill, stroke, StrokeWidth);
        // counter++;
        // return "".PadLeft(3, ' ') + dispSVG;
        return "";
    }

    public void deletePolyline(int id)
    {
        
    }
    
    public void updatePolyline(int id, int x, int y, int r)
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