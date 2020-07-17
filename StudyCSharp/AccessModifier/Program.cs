using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    class WaterHeater
    {
        protected int Temp;

        public void SetTemp(int Temp)
        {
            if(Temp < -5 || Temp > 42)
            {
                throw new Exception("Out of temperature range");
            }
            this.Temp = Temp;
        }

        internal void TurnOnWater()
        {
            Console.WriteLine($"Turn on water : {Temp}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WaterHeater heater = new WaterHeater();
                heater.SetTemp(42);
                heater.TurnOnWater();

                heater.SetTemp(52);
                heater.TurnOnWater();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
