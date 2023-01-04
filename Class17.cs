/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    using static TrafficLight;
   class Class17
    {
        public static async Task Main(string[] Args)
        {
            TrafficLightState NextLightUsingRecords(TrafficLightState trafficLightState)
                => trafficLightState switch
                {
                    { CurrentLight: AmberBlink } =>
                    new TrafficLightState(Red, trafficLightState.PreviousLight, 3000),
                    { CurrentLight: Red } =>
                    new TrafficLightState(Green, trafficLightState.CurrentLight, 2000),
                    { CurrentLight: Green } =>
                    new TrafficLightState(GreenBlink, trafficLightState.CurrentLight,
                    100, 1),
                    { CurrentLight: GreenBlink, BlinkCount: < 3 } =>
                    trafficLightState with
                    { BlinkCount = trafficLightState.BlinkCount + 1 },
                    { CurrentLight: GreenBlink } =>
                    new TrafficLightState(Amber, trafficLightState.CurrentLight, 200),
                    { CurrentLight: Amber, PreviousLight: GreenBlink } =>
                    new TrafficLightState(Red, trafficLightState.CurrentLight, 3000),
                    _ => throw new InvalidOperationException()
                };
            TrafficLightState currentLightState = new(Red, Red, 2000);
            for(int i=0; i <20; i++)
            {
                currentLightState = NextLightUsingRecords(currentLightState);
                Console.WriteLine($"{currentLightState.CurrentLight}," +
                    $"{currentLightState.Milliseconds}");
                await Task.Delay(currentLightState.Milliseconds);
            }
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

    public record TrafficLightState(TrafficLight CurrentLight,
        TrafficLight PreviousLight, int Milliseconds, int BlinkCount = 0);
}
*/