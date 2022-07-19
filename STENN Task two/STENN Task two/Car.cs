using System;

namespace STENN_Task_two
{
    public class Car
    {
        public Car
        (
            string company,
            string model,
            string color,
            string description = null
        )
        {
            Company = company;
            Model = model;
            Color = color;
            Description = description;
        }

        public string Company { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }

        public override int GetHashCode()
        {
            return HashCode.Combine(Company, Model, Color);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Car))
            {
                return false;
            }

            return Equals((Car)obj);
        }

        private bool Equals(Car otherCar)
        {
            return (otherCar.Model == this.Model && otherCar.Color == this.Color && otherCar.Company == this.Company);
        }
    }
}