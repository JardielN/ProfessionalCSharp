/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    using static TrafficLight;
    class Class16
    {
        public static async Task Main(string[] Args)
        {
            (TrafficLight Current, TrafficLight Previous)
                NextLightUsingTuples(TrafficLight current, TrafficLight previous) =>
                (current, previous) switch
                {
                    (Red, _) => (Amber, current),
                    (Amber, Red) => (Green, current),
                    (Green, _) => (Amber, current),
                    (Amber, Green) => (Red, current),
                    _=> throw new InvalidOperationException()
                };

            var previousLight = Red;
            var currentLight = Red;
            for(int i=0; i<10; i++)
            {
                (currentLight, previousLight) = NextLightUsingTuples(currentLight,
                    previousLight);
                Console.Write($"{currentLight} - ");
                await Task.Delay(1000);
            }
            Console.WriteLine();
        }
    }

    public enum TrafficLight
    {
        Red,
        Amber,
        Green,
        GreenBlink,
        AmberBlink
    }
}

*/