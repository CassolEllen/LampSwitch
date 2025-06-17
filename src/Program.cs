using Devices;
using Controllers;

class Program
{
    static void Main()
    {
        IDevice lamp = new Lamp();
        var wallSwitch = new Switch(lamp);

        wallSwitch.Press(); // Liga
        wallSwitch.Press(); // Desliga
    }
}