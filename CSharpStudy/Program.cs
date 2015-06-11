using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CSharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test.WriteXML();
            //Test.ReadXML();
            //int? a = null;
            //switch (a)
            //{
            //    case 0:
            //        Console.WriteLine("0");
            //        break;
            //    case null:
            //        Console.WriteLine("Null");
            //        break;
            //}
            ////int b = (int)a;
            ////Console.WriteLine(b);
            //Console.ReadLine();

            System.Collections.Generic.List<Shape> shapes = new System.Collections.Generic.List<Shape>();
            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());
            shapes.Add(new Circle());
            int[] a = { 1, 2, 3, 5, 3, 2, 0 };
            a.OrderBy(p => p);
            // Polymorphism at work #2: the virtual method Draw is
            // invoked on each of the derived classes, not the base class.
            foreach (Shape s in shapes)
            {
                s.Draw();
            }

            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
 
    public class Book
    {
        public String title;
        public void Method1(string s)
        {
            s += s;
        }
    }

    class Test
    {
        public static void WriteXML()
        {
            Book overview = new Book();
            overview.title = "Serialization Overview";
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Book));

            System.IO.StreamWriter file = new System.IO.StreamWriter(
                @"d:\SerializationOverview.xml");
            writer.Serialize(file, overview);
            file.Close();
        }

        public static void ReadXML()
        {
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(Book));
            System.IO.StreamReader file = new System.IO.StreamReader(
                @"d:\SerializationOverview.xml");
            Book overview = new Book();
            overview = (Book)reader.Deserialize(file);
            overview.Method1("a");
            Console.WriteLine(overview.title);

        }

    }

    public class Shape
    {
        // A few example members
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        // Virtual method
        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            // Code to draw a circle...
            Console.WriteLine("Drawing a circle");
            base.Draw();
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            // Code to draw a rectangle...
            Console.WriteLine("Drawing a rectangle");
            base.Draw();
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            // Code to draw a triangle...
            Console.WriteLine("Drawing a triangle");
            base.Draw();
        }
    }

}
