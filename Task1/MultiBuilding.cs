using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public sealed class MultiBuilding : Building
    {
        int floorsNumber;

        public int FloorsNumber 
        {
            get { return floorsNumber; }
            set
            {
                if (value < 1)
                {
                    floorsNumber = 1;
                }
                else
                {
                    floorsNumber = value;
                }
            }
        }
        public MultiBuilding(string adress, double length, double width, double height, int floorsNumber) : base(adress, length, width, height)
        {
            FloorsNumber = floorsNumber;
           
        }

        public override string Print()
        {
            string result = base.Print();
            return result+$", количество этажей в здании - {floorsNumber}";
        }
    }
}
