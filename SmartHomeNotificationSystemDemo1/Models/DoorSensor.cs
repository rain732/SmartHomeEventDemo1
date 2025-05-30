using SmartHomeNotificationSystem.Interfaces;

namespace SmartHomeNotificationSystem.Models;

public class DoorSensor : ISensor
{
    public event SensorEventHandler SensorTriggered;

    public void Trigger()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Door Opened!");
        SensorTriggered?.Invoke(this ,"The Door was open");
        Console.WriteLine();
    }

    public override string ToString()
    {
        return "I am Door, ";
    }
}
