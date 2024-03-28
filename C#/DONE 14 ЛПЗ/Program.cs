using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DONE_14_ЛПЗ
{    
    class Program
    {
        static void Main(string[] args)
        {
            // Задачи 1 и 2: работа с классом Car
            Car myCar = new Car("Toyota", "Camry", 2020);
            myCar.DisplayInfo();

            // Задача 3: демонстрация инкапсуляции
            // set
            myCar.Make = "Ford";
            // get
            Console.WriteLine(myCar.Make);

            // Задача 4: использование класса Garage
            Garage myGarage = new Garage();
            myGarage.AddCar(new Car("Tesla", "Model S", 2022));
            myGarage.AddCar(new Car("Ford", "Mustang", 2021));
            myGarage.DisplayCars();
        }
    }
}
