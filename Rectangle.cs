using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_task
{
    public class Rectangle
    {

		private double Width;

		public double width
		{
			get { return Width; }
			set 
			{
				if (value < 0) 
				{
					Width = 0;
				}
				else
				{
					 Width=value;
				}
			}
		}
        private double Heigth;

        public double height
        {
            get { return Heigth; }
            set
            {
                if (value < 0)
                {
                    Heigth = 0;
                }
                else
                {
                   Heigth=value;
                }
            }
        }
        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }
        public void CalculateArea()
        {
            double area = width * height;
            Console.WriteLine($"Area = width*height = {area}");
        }
        public void CalculatePerimeter()
        {
            double perimeter = 2*(width + height);
            Console.WriteLine($"Perimeter = 2*(width + height) = {perimeter}");
        }
    }
}
