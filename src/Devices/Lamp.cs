using System;

namespace Devices;

public enum LampState { On, Off }

public class Lamp : IDevice
{
    private LampState _state = LampState.Off;

    public void Operate()
    {
        _state = _state == LampState.On ? LampState.Off : LampState.On;
        Console.WriteLine($"Luz {(_state == LampState.On ? "Ligada" : "Desligada")}");
    }
}