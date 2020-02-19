using System;
using System.Collections.Generic;
using System.Text;

namespace everylessons
{
    class AllCars
    {
        Car[] cars;
        int num;

        public AllCars(int max)
        {
            this.cars = new Car[max];
            this.num = 0;
        }
        
        public bool AddCar(Car car)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] == null)
                {
                    cars[i] = car;
                    return true;
                }
            }
            return false;
        }

        public void PrintCarList(int min, int max)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].GetIsRented())
                {
                    if(cars[i].Status(min, max))
                    {
                        Console.WriteLine(cars[i].GetLicenseNum());
                    }
                }
            }
        }
    }
}
