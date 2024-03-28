using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DONE_14_ЛПЗ
{
    public class Garage
    {
        private List<Car> cars = new List<Car>();

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void DisplayCars()
        {
            foreach (Car car in cars)
            {
                car.DisplayInfo();
            }    
        }
    }
}
