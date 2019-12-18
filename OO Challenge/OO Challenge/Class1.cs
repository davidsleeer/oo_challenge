using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Challenge
{
    public class shape
    {
        public string Color;
        public shape(string Color)
        {
            this.Color = Color;

        }
    }

    public class Quadrilateral : shape
    {
        public int Side1Length;
        public int Side2Length;
        public int Side3Length;
        public int Side4Length;
        
        
        public Quadrilateral(string Color,int Side1Length, int Side2Length, int Side3Length, int Side4Length) :base(Color)
        {
            this.Color = base.Color;
            this.Side1Length = Side1Length;
            this.Side2Length = Side2Length;
            this.Side3Length = Side3Length;
            this.Side4Length = Side4Length;
        }

        public int GetPerimeter()
        {
            int perimeter = this.Side1Length + this.Side2Length + this.Side3Length + this.Side4Length;
            return perimeter;
        }


    }

    public class Square : Quadrilateral
    {

         public Square(string Color, int Side1Length) : base(Color,Side1Length,0,0,0)
    {
            

    }
    public int GetArea()
        {
            int area = this.Side1Length * this.Side1Length;
            return area;
        }
        public int GetPerimeter()
        {
            int perimeter = this.Side1Length * 4;
            return perimeter;
        }


    }

    public class Rectangle : Quadrilateral
    {
        public Rectangle(string Color, int Side1Length, int Side2Length) : base(Color,Side1Length,Side2Length, 0, 0)
        {
            

                 

        }
        public int GetPerimeter()
        {
            int perimeter = (this.Side1Length + this.Side2Length ) * 2;
            return perimeter;
        }

        public int GetArea()
        {
            int area = this.Side1Length * this.Side2Length;
            return area;
        }
    }

    class shapes
    {
        static void Main(string[] args)
        {
           

            

           
           
            
        }
    }


}
