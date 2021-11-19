using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vip70
{
    public class Car
    {
       

        private int Id { get; set; }
        private string Type { get; set; }
        private float Price { get; set; }

        private string Model { get; set; }

        private string Brand { get; set; }
        private string Condition { get; set; }
        private int Year { get; set; }

        public Car(int id, string type, float price, string model, string brand, string condition, int year)
        {
            this.Id = id;
             this.Type = type;
             this.Price = price;
             this.Model = model;
             this.Brand = brand;
             this.Condition = condition;
            this.Year = year;
        }

        public string GetCarType()
        {
            return this.Type;
        }

        public string GetCarModel()
        {
            return this.Model;
        }

        public override string ToString()
        {
            return $"{Id.ToString()} | {Price.ToString("C")} | {Model} | {Condition} | {Brand} | {Year.ToString()}";
        }
    }
}
