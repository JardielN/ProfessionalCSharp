/*
using System;
using static TrafficLight;


//TrafficLight NextLightClassic(TrafficLight light)
//{
//  switch (light)
//{
//  case TrafficLight.Green:
//    return TrafficLight.Amber;
//case TrafficLight.Amber:
//  return TrafficLight.Red;
// case TrafficLight.Red:
//   return TrafficLight.Green;
//default:
//  throw new InvalidOperationException();
//}
//}


//TrafficLight NextLight(TrafficLight light)
//  => light switch
//{
//  TrafficLight.Green => TrafficLight.Amber,
//TrafficLight.Amber => TrafficLight.Red,
//TrafficLight.Red => TrafficLight.Green,
//_ => throw new InvalidOperationException()
//};

TrafficLight NextLight(TrafficLight light) =>
    light switch
    {
        Green => Amber,
        Amber => Red,
        Red => Green,
        _ => throw new InvalidOperationException()
    };


enum TrafficLight
{
    Red, 
    Amber,
    Green
}

*/