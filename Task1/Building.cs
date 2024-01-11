using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Building
    {
        const int minDementions = 3;
        string adress;
        double length;
        double width;
        double height;

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public double Length
        {
            get { return length; }
            set
            {
                if (value < minDementions)
                {
                    length = minDementions;
                }
                else
                {
                    length = value;
                }
            }
        }

        public double Width
        {
            get { return width; }
            set 
            {
                if (value<minDementions)
                {
                    width = minDementions;
                }
                else
                {
                    width = value;
                }
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value < minDementions)
                {
                    height = minDementions;
                }
                else
                {
                    height = value;
                }
            }
        }



        public Building(string adress, double length, double width, double height)
        {
            Adress = adress;
            Length=length; 
            Width=width;
            Height=height;
        }


        public virtual string Print()
        {
            string result = $"Адрес здания - {adress}, длина здания - {length}, ширина здания - {width}, высота здания - {height}";
            return result ;
        }
    }
}
