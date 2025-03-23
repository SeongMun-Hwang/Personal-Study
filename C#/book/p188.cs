using System.Collections;
using static System.Console;
using System;

namespace CsConsole
{
    class MainApp
    {
        class Car
        {
            public string Model { get; set;}
            public DateTime ProducedAt { get; set;}
        }
        static string GetNickname(Car car)
        {
            var GenerateMesasage = (Car car, string nickname) =>
            $"{car.Model} produced in {car.ProducedAt.Year} is {nickname}";

            if (car is Car { Model: "Mustang", ProducedAt.Year: 1967 })
                return GenerateMesasage(car, "Fastback");
            else if (car is Car { Model: "Mustang", ProducedAt.Year: 1976 })
                return GenerateMesasage(car, "Cobra 2");
            else 
                return GenerateMesasage(car, "Unknown");
        }
        static void Main(string[] args)
        {
            WriteLine(GetNickname(new Car() { Model = "Mustang", ProducedAt = new DateTime(1967, 11, 23) }));
            WriteLine(GetNickname(new Car() { Model = "Mustang", ProducedAt = new DateTime(1976, 6, 7) }));
            WriteLine(GetNickname(new Car() { Model = "Mustang", ProducedAt = new DateTime(2024, 12, 23) }));
            ReadLine();
        }
    }
}