using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vip70
{
    public class CarList
    {
        private static List<Car> Cars = new List<Car>();

        public void AddCar(int Id, string Type, float Price, string Model, string Brand, string Condition, int Year)
        {
            Cars.Add(new Car(Id, Type, Price, Model, Brand, Condition, Year));
            Console.WriteLine("Adding the Car" + Model);
        }

        public List<Car> GetAllCars()
        {
            return Cars;
        }

        public List<Car> GetIndustrialCars()
        {
            List<Car> industrialCars = new List<Car>();
            foreach(Car car in Cars)
            {
                if (car.GetCarType() == "Industrial")
                {
                    industrialCars.Add(car);

                }
            }
            return industrialCars;
        }

        public List<Car> GetPassengerCars()
        {
            List<Car> passengerCars = new List<Car>();
            foreach(Car car in Cars)
            {
                if(car.GetCarType() == "Passenger")
                {
                    passengerCars.Add(car);
                }
            }
            return passengerCars;
        }

        public List<Car> GetCarsByModel(string model)
        {
            List<Car> carsByModel = new List<Car>();
            foreach (Car car in Cars)
            {
                if (car.GetCarModel() == model)
                {
                    carsByModel.Add(car);
                }
            }
            return carsByModel;
        }

        public List<Car> SearchCarsByModel(string model)
        {
            List<Car> carsByModel = new List<Car>();
            foreach (Car car in Cars)
            {
                if (car.GetCarModel().Contains(model))
                {
                    carsByModel.Add(car);
                }
            }
            return carsByModel;
        }

        public List<Car> SearchCarsByIndustry(string industry)
        {
            switch (industry)
            {
                case "Passenger":
                case "passenger":
                    return GetPassengerCars();
                case "Industrial":
                case "industrial":
                    return GetIndustrialCars();
                default:
                    return GetAllCars();
            }
        }

        public List<Car> GetCarsByArguments(string model = "", string industry = "")
        {
            if (string.IsNullOrWhiteSpace(model) && !string.IsNullOrWhiteSpace(industry))
            {
                return SearchCarsByIndustry(industry);
            }
            else if (!string.IsNullOrWhiteSpace(model) && string.IsNullOrWhiteSpace(industry))
            {
                return SearchCarsByModel(model);
            }
            else if (!string.IsNullOrWhiteSpace(model) && !string.IsNullOrWhiteSpace(industry))
            {
                return SearchCarsByModel(model).Intersect(SearchCarsByIndustry(industry)).ToList();
            }
            else
            {
                return GetAllCars();
            }
        }

        public void DisplayCars()
        {
            foreach (Car car in Cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

    }
}
