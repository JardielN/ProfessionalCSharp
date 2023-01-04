/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    // EVENTS
    class Class38
    {
        public static void Main(String[] Args)
        {
            CarDealer dealer = new();
            Consumer sebastian = new("Sebastian");
            dealer.NewCarCreated += sebastian.NewCarIsHere;
            dealer.CreateANewCar("Williams");

            Consumer max = new("Max");
            dealer.NewCarCreated += max.NewCarIsHere;
            dealer.CreateANewCar("Aston Martin");
            dealer.NewCarCreated -= sebastian.NewCarIsHere;
            dealer.CreateANewCar("Ferrari");
        }
    }

    public class CarInfoEventArgs : EventArgs
    {
        public string Car { get; }
        public CarInfoEventArgs(string car) => Car = car;
    }

    public class CarDealer
    {
        public event EventHandler<CarInfoEventArgs>? NewCarCreated;
        public void CreateANewCar(string car)
        {
            Console.WriteLine($"CarDealer, new car {car}");
            RaiseNewCarCreated(car);
        }

        private void RaiseNewCarCreated(string car)
            => NewCarCreated?.Invoke(this, new CarInfoEventArgs(car));
    }

    public record Consumer(string Name)
    {
        public void NewCarIsHere(object? sender, CarInfoEventArgs e)
            => Console.WriteLine($"{Name}: car {e.Car} is new");
    }
}
*/