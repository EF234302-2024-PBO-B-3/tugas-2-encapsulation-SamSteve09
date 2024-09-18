using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Calendar
{
    public class Date
    {

        public int Month {  get; private set; }
        public int Day {  get; private set; }
        public int Year {  get; private set; }
        
        public Date(int Mon, int Da, int Yea)
        {
            if (Da > 31 || Da < 1 || Mon > 12 || Mon < 1)
            {
                Day = 1;
                Month = 1;
                Year = 1970;
            }
            else
            {
                Month = Mon;
                Day = Da;
                Year = Yea;
            }
        }
        public void DisplayDate() 
        { 
            Console.WriteLine($"{this.Month}/{this.Day}/{this.Year}");
        }

    }

}
