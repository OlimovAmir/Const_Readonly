using Const_Readonly;
using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Car car = new Car(new MyLogger());

        car.Drive();
        car.StartEngine();
    }
}