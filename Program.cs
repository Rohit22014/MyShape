using System;
using System.IO;

namespace MyShape
{
    class Program
    {

        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Rectangle r1 = new Rectangle();
            Ellipse e1 = new Ellipse();
            Line l1 = new Line();
            bool stop = false;

            int counter = 0;
                using (StreamWriter sw = File.CreateText("C:/Users/rohit/Downloads/MyShape/MyShape/sample.svg"))
                {
                    while(!stop)
                    {
                    Console.WriteLine("Type any shape to create it");
                    Console.WriteLine("If its the first time type 'start'");
                    Console.WriteLine("When your finished type 'exit'");
                    string a = Console.ReadLine();
                    if (a == "start")
                    {
                        sw.WriteLine(
                            String.Format(@"<svg height=""400"" width=""400"" xmlns=""http://www.w3.org/2000/svg"">"));
                        Console.WriteLine("start added");
                    }
                    else if (a == "Circle")
                    {
                        Console.WriteLine("Circle x =");
                            var x = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Circle y =");
                            var y = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Circle radius =");
                            var r = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Circle stroke");
                            var stroke = Console.ReadLine();
                            Console.WriteLine("Circle width");
                            var width = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Circle colour = ");
                            var colour = Console.ReadLine();
                            sw.WriteLine(c1.addCircle(counter, x, y, r,stroke, width, colour));
                            counter++;
                    }
                    else if (a == "Rectangle")
                    {
                        Console.WriteLine("Rectangle Height =");
                            var height = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Rectangle Width =");
                            var width = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Rectangle rx =");
                            var rx = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Rectangle ry = ");
                            var ry = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Rectangle fill = ");
                            var colour = Console.ReadLine();
                            Console.WriteLine("Rectangle stroke = ");
                            var stroke = Console.ReadLine();
                            Console.WriteLine("Rectangle stroke-width = ");
                            var strokeWidth = Int32.Parse(Console.ReadLine());
                            sw.WriteLine(r1.addRectangle(counter, height, width, rx, ry, colour, stroke, strokeWidth));
                            counter++;
                            Console.WriteLine("Rectangle added");
                    }
                    else if (a == "Ellipse")
                    {
                        Console.WriteLine("Ellipse  cx=");
                            var cx = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Ellipse  cy=");
                            var cy = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Ellipse rx =");
                            var rx = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Ellipse ry = ");
                            var ry = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Ellipse fill = ");
                            var colour = Console.ReadLine();
                            Console.WriteLine("Ellipse stroke = ");
                            var stroke = Console.ReadLine();
                            Console.WriteLine("Ellipse stroke-width = ");
                            var strokeWidth = Int32.Parse(Console.ReadLine());
                            sw.WriteLine(e1.addEllipse(counter, cx, cy, rx, ry, colour, stroke, strokeWidth));
                            counter++;
                            Console.WriteLine("Ellipse added");
                    }
                    else if (a == "Line")
                    {
                        
                        Console.WriteLine("Line  x1=");
                            var x1 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Line  y1=");
                            var y1 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Line x2 =");
                            var x2 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Line y2 = ");
                            var y2 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Line stroke = ");
                            var stroke = Console.ReadLine();
                            Console.WriteLine("Line stroke-width = ");
                            var strokeWidth = Int32.Parse(Console.ReadLine());
                            sw.WriteLine(l1.addLine(counter, x1, y1, x2, y2, stroke, strokeWidth));
                            counter++;
                            Console.WriteLine("Line added");
                    }
                    else if (a == "exit")
                    {
                        sw.WriteLine("</svg>");
                        Console.WriteLine("File created");
                        stop = true;
                        break;
                        
                    }
                    else
                    {
                        Console.WriteLine("Not a input. try again");
                    }

                }
            }
        }
        }
    }