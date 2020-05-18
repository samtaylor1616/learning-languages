using System;

namespace Inheritance
{
    public class Automobile
    {
        public string Make { get; }
        public string Model { get; }
        public int Year { get; }

        public override string ToString() => $"{Year} {Make} {Model}";

        public Automobile(string make, string model, int year)
        {
            if (!isValidString(make))
                throw new ArgumentException("Make cannot be an empty string or null");

            if (!isValidString(model))
                throw new ArgumentException("Model cannot be an empty string or null");

            if (year < 1857 || year > DateTime.Now.Year)
                throw new ArgumentException($"Year must be within 1857 and {DateTime.Now.Year}");

            Make = make;
            Model = model;
            Year = year;
        }

        private bool isValidString(string str)
        {
            return str != null || !String.IsNullOrWhiteSpace(str);
        }
    }
}